using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmClient
{
    public partial class frmClient : Form
    {
        private string clientName = string.Empty;

        private TcpClient tcpClient;
        private NetworkStream stream;
        private Thread receiveThread;
        private UdpClient udpListener;
        private bool listening = false;

        public frmClient()
        {
            InitializeComponent();
        }

        #region Private Method

        private void AppendChatBubble(string sender, string message, bool isOwnMessage = false, bool isSystem = false)
        {
            if (txtMessages.InvokeRequired)
            {
                txtMessages.Invoke((MethodInvoker)(() => AppendChatBubble(sender, message, isOwnMessage, isSystem)));
            }
            else
            {
                string header = isSystem ? $"========== {sender} ==========" : $"[{sender}]";
                string content = message;
                string separator = new string('-', 40);

                HorizontalAlignment alignment = HorizontalAlignment.Left;

                if (isSystem)
                {
                    alignment = HorizontalAlignment.Center;
                }
                else if (isOwnMessage)
                {
                    alignment = HorizontalAlignment.Right;
                }

                AppendLine(header, alignment);
                AppendLine(content, alignment);
                AppendLine(separator, alignment);
            }
        }

        private void AppendLine(string text, HorizontalAlignment alignment)
        {
            txtMessages.SuspendLayout();

            txtMessages.SelectionStart = txtMessages.TextLength;
            txtMessages.SelectionLength = 0;
            txtMessages.SelectionAlignment = alignment;
            txtMessages.AppendText(text + "\r\n");

            txtMessages.SelectionStart = txtMessages.Text.Length;
            txtMessages.ScrollToCaret();

            txtMessages.ResumeLayout();

        }

        private void StartListeningForServers()
        {
            udpListener = new UdpClient(8888);
            udpListener.EnableBroadcast = true;
            listening = true;

            new Thread(() =>
            {
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, 8888);

                while (listening)
                {
                    try
                    {
                        byte[] data = udpListener.Receive(ref endPoint);
                        string message = Encoding.ASCII.GetString(data);
                        if (message.StartsWith("CHAT_SERVER|"))
                        {
                            string serverIP = message.Split('|')[1];

                            txtServerIP.Invoke((MethodInvoker)(() =>
                            {
                                if (!txtServerIP.Items.Contains(serverIP))
                                {
                                    txtServerIP.Items.Add(serverIP);
                                }
                            }));
                        }
                    }
                    catch
                    {
                        // Listener stopped or error occurred
                    }
                }
            })
            { IsBackground = true }.Start();
        }

        private void StopListeningForServers()
        {
            listening = false;
            udpListener?.Close();
        }

        private void ReceiveMessages()
        {
            byte[] buffer = new byte[1024];
            int bytesRead;

            try
            {
                while (true)
                {
                    bytesRead = stream.Read(buffer, 0, buffer.Length);
                    if (bytesRead == 0)
                    {
                        // Server has closed the connection
                        break;
                    }

                    string receivedMessage = Encoding.ASCII.GetString(buffer, 0, bytesRead).Trim();

                    txtMessages.Invoke((Action)(() =>
                    {
                        if (receivedMessage.StartsWith(clientName + ":"))
                        {
                            return; // Own message
                        }

                        txtMessages.SelectionAlignment = HorizontalAlignment.Left;
                        txtMessages.AppendText(receivedMessage + "\r\n");
                    }));
                }
            }
            catch (Exception ex)
            {
                // Connection error (e.g., server stopped)
            }

            // If we reach here, the server is likely down
            txtMessages.Invoke((Action)(() =>
            {
                AppendChatBubble("System", "Disconnected from server. Server may have stopped.", isSystem: true);
            }));

            tcpClient?.Close();
        }
        #endregion

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(clientName))
            {
                MessageBox.Show("Please set your name before connecting.");
                return;
            }

            try
            {
                string serverIp = txtServerIP.SelectedItem?.ToString();
                if (string.IsNullOrEmpty(serverIp))
                {
                    MessageBox.Show("Please select a server IP to connect.");
                    return;
                }

                tcpClient = new TcpClient(serverIp, 5000);
                stream = tcpClient.GetStream();

                receiveThread = new Thread(ReceiveMessages);
                receiveThread.Start();

                txtMessages.AppendText("Connected to server...\r\n");

                string joinMsg = $"============== {clientName} has joined =============\r\n";
                byte[] nameBytes = Encoding.ASCII.GetBytes(joinMsg);
                stream.Write(nameBytes, 0, nameBytes.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed: " + ex.Message);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string message = txtInput.Text.Trim();

            if (!string.IsNullOrEmpty(message) && !string.IsNullOrEmpty(clientName))
            {
                string fullMessage = clientName + ": " + message + "\r\n";

                byte[] messageBytes = Encoding.ASCII.GetBytes(fullMessage);
                stream.Write(messageBytes, 0, messageBytes.Length);

                // Show own message on the right
                txtMessages.SelectionAlignment = HorizontalAlignment.Right;
                txtMessages.AppendText(fullMessage);

                txtInput.Clear();
            }
        }

        private void btnSetName_Click(object sender, EventArgs e)
        {
            clientName = txtUsername.Text.Trim();

            if (string.IsNullOrEmpty(clientName))
            {
                MessageBox.Show("Please enter a name before chatting.");
                return;
            }

            txtUsername.Enabled = false;
            btnSetName.Enabled = false;
        }

        private void frmClient_Load(object sender, EventArgs e)
        {
            txtServerIP.DropDownStyle = ComboBoxStyle.DropDownList;
            StartListeningForServers();
            txtUsername.Text = Environment.UserName;
        }

        private void frmClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopListeningForServers();
        }

        private void btnRefreshServers_Click(object sender, EventArgs e)
        {
            btnRefreshServers.Enabled = false;
            txtServerIP.Items.Clear();

            StopListeningForServers();

            // Slight delay to simulate refresh feedback
            Task.Run(() =>
            {
                Thread.Sleep(300); // Optional delay
                this.Invoke((MethodInvoker)(() =>
                {
                    StartListeningForServers();
                    btnRefreshServers.Enabled = true;
                }));
            });
        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !e.Shift)
            {
                e.SuppressKeyPress = true; // prevent newline or ding sound
                btnSend_Click(sender, e);
            }
        }
    }
}
