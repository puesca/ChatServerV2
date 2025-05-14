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
            int bubbleMaxWidth = 300;
            int sidePadding = 20;

            // ========== Create timestamp label ==========
            Label timestampLabel = new Label();
            timestampLabel.AutoSize = true;
            timestampLabel.Font = new Font("Segoe UI", 6, FontStyle.Regular);
            timestampLabel.ForeColor = Color.Gray;
            timestampLabel.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            timestampLabel.Margin = new Padding(5, 0, 5, 2);

            // ========== Create message bubble ==========
            Label bubble = new Label();
            bubble.AutoSize = true;
            bubble.MaximumSize = new Size(bubbleMaxWidth, 0);
            bubble.Font = new Font("Segoe UI", 10);
            bubble.Padding = new Padding(10);
            bubble.Text = message;
            bubble.BackColor = isSystem ? Color.FromArgb(89, 21, 23) :
                              isOwnMessage ? Color.FromArgb(11, 128, 42) :
                                             Color.FromArgb(77, 108, 135);
            bubble.ForeColor = Color.White;
            bubble.BorderStyle = BorderStyle.Fixed3D;
            bubble.TextAlign = ContentAlignment.MiddleLeft;
            bubble.Margin = new Padding(5);

            // ========== Wrapper panel ==========
            Panel bubbleWrapper = new Panel();
            bubbleWrapper.AutoSize = true;
            bubbleWrapper.Width = txtMessages.ClientSize.Width - 20;
            bubbleWrapper.BackColor = Color.Transparent;

            // Temporarily add to wrapper to measure sizes
            bubbleWrapper.Controls.Add(timestampLabel);
            bubbleWrapper.Controls.Add(bubble);
            bubbleWrapper.PerformLayout();

            // Align to the right or left
            if (isOwnMessage)
            {
                int rightAlignedX = bubbleWrapper.Width - bubble.Width - sidePadding;
                bubble.Left = rightAlignedX;
                timestampLabel.Left = bubbleWrapper.Width - timestampLabel.Width - sidePadding;
            }
            else
            {
                bubble.Left = 10;
                timestampLabel.Left = 10;
            }

            // ========== Vertical stacking ==========
            timestampLabel.Top = 0;
            bubble.Top = timestampLabel.Bottom + 2;

            // ========== Add to wrapper ==========
            bubbleWrapper.Controls.Clear(); // Clear to re-add in order
            bubbleWrapper.Controls.Add(timestampLabel);
            bubbleWrapper.Controls.Add(bubble);

            // ========== Add to messages panel ==========
            txtMessages.Controls.Add(bubbleWrapper);
            txtMessages.ScrollControlIntoView(bubbleWrapper);
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
                        // Skip own message (already displayed locally)
                        if (receivedMessage.StartsWith(clientName + ":"))
                            return;

                        // Append received message as a chat bubble (left-aligned)
                        AppendChatBubble("Server", receivedMessage, isOwnMessage: false);
                    }));
                }
            }
            catch (Exception ex)
            {
                // Optionally log ex.Message
            }

            // Connection lost — show system message
            txtMessages.Invoke((Action)(() =>
            {
                AppendChatBubble("System", "Disconnected from server. Server may have stopped.", isSystem: true);
            }));

            tcpClient?.Close();
        }

        #endregion

        private void btnConnect_Click(object sender, EventArgs e)
        {
            btnSetName_Click(sender, e);
            if (string.IsNullOrEmpty(clientName))
            {
                MessageBox.Show("Please set your name before connecting.", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                string serverIp = txtServerIP.Text?.Trim();
                if (string.IsNullOrEmpty(serverIp))
                {
                    MessageBox.Show("Please select a server IP to connect.", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                tcpClient = new TcpClient(serverIp, 5000);
                stream = tcpClient.GetStream();

                receiveThread = new Thread(ReceiveMessages);
                receiveThread.Start();

                txtMessages.Text += "Connected to server...\r\n";

                string joinMsg = $" {clientName} has joined \r\n";
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

                AppendChatBubble(clientName, message, isOwnMessage: true);

                txtInput.Text = string.Empty;
            }
        }

        private void btnSetName_Click(object sender, EventArgs e)
        {
            clientName = txtUsername.Text.Trim();

            if (string.IsNullOrEmpty(clientName))
            {
                MessageBox.Show("Please enter a name before chatting.", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            txtUsername.Enabled = false;
            btnSetName.Enabled = false;
        }

        private void frmClient_Load(object sender, EventArgs e)
        {
            txtServerIP.DropDownStyle = ComboBoxStyle.DropDownList;
            StartListeningForServers();
            //txtUsername.Text = Environment.UserName;
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

        
            Task.Run(() =>
            {
                Thread.Sleep(300); 
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
                e.SuppressKeyPress = true;
                btnSend_Click(sender, e);
            }
        }
    }
}
