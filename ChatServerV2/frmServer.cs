using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ChatServerV2
{
    public partial class frmServer : Form
    {

        private TcpListener server;
        private Thread listenThread;
        private List<TcpClient> clients = new List<TcpClient>();
        private List<string> chatHistory = new List<string>();
        private UdpClient udpBroadcaster;
        private bool broadcasting = false;

        public frmServer()
        {
            InitializeComponent();

            txtServerIP.Text = GetLocalIPAddress();
        }

        #region private Method
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
            txtMessages.SuspendLayout(); // Optional, improves performance

            txtMessages.SelectionStart = txtMessages.TextLength;
            txtMessages.SelectionLength = 0;
            txtMessages.SelectionAlignment = alignment;
            txtMessages.AppendText(text + "\r\n");

            // Move caret to end, then scroll
            txtMessages.SelectionStart = txtMessages.Text.Length;
            txtMessages.ScrollToCaret();

            txtMessages.ResumeLayout();
        }

        private void StartBroadcastingServer()
        {
            udpBroadcaster = new UdpClient();
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Broadcast, 8888);

            broadcasting = true;

            new Thread(() =>
            {
                while (broadcasting)
                {
                    string message = "CHAT_SERVER|" + GetLocalIPAddress();
                    byte[] data = Encoding.ASCII.GetBytes(message);
                    udpBroadcaster.Send(data, data.Length, endPoint);
                    Thread.Sleep(1000); // Broadcast every 1 sec
                }
            })
            { IsBackground = true }.Start();
        }

        private void StopBroadcastingServer()
        {
            broadcasting = false;
            udpBroadcaster?.Close();
        }

        private string GetLocalIPAddress()
        {
            foreach (var ip in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1"; // fallback to localhost
        }

        private void ListenForClients()
        {
            try
            {
                server.Start();
                StartBroadcastingServer();

                while (true)
                {
                    TcpClient client;

                    try
                    {
                        client = server.AcceptTcpClient();
                    }
                    catch (SocketException)
                    {
                        // Server has been stopped, exit the loop
                        break;
                    }

                    clients.Add(client);

                    // Send chat history
                    SendChatHistoryToClient(client);

                    // Notify all clients
                    string joinMessage = "A new client has joined the chat.";
                    BroadcastMessage(joinMessage);

                    txtMessages.Invoke((Action)(() =>
                        txtMessages.AppendText(joinMessage + "\r\n")));

                    Thread clientThread = new Thread(HandleClientComm);
                    clientThread.Start(client);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in server loop: " + ex.Message);
            }
        }

        private void SendChatHistoryToClient(TcpClient client)
        {
            try
            {
                NetworkStream stream = client.GetStream();
                foreach (string message in chatHistory)
                {
                    byte[] messageBytes = Encoding.ASCII.GetBytes(message + "\r\n");
                    stream.Write(messageBytes, 0, messageBytes.Length);
                }
            }
            catch
            {
                // Handle exceptions (e.g., client disconnected early)
            }
        }

        private void HandleClientComm(object obj)
        {
            TcpClient client = (TcpClient)obj;

            try
            {
                NetworkStream stream = client.GetStream();
                byte[] buffer = new byte[1024];
                int bytesRead;

                while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) != 0)
                {
                    string message = Encoding.ASCII.GetString(buffer, 0, bytesRead).Trim();

                    int separatorIndex = message.IndexOf(": ");
                    if (separatorIndex > 0)
                    {
                        string sender = message.Substring(0, separatorIndex);
                        string msg = message.Substring(separatorIndex + 2);
                        AppendChatBubble(sender, msg);
                    }
                    else
                    {
                        AppendChatBubble("System", message, false, true);
                    }

                    BroadcastMessage(message);
                }
            }
            catch (Exception ex)
            {
                // Optionally log or display error
                AppendChatBubble("System", "A client has disconnected unexpectedly.", isSystem: true);
            }
            finally
            {
                // Ensure client connection is cleaned up
                client.Close();
            }
        }

        private void BroadcastMessage(string message)
        {
            // Store in history
            chatHistory.Add(message);

            byte[] messageBytes = Encoding.ASCII.GetBytes(message + "\r\n");
            foreach (var client in clients)
            {
                NetworkStream stream = client.GetStream();
                stream.Write(messageBytes, 0, messageBytes.Length);
            }
        }
        #endregion

        private void btnStartServer_Click(object sender, EventArgs e)
        {
            string ip = txtServerIP.Text;
            if (string.IsNullOrEmpty(ip))
            {
                MessageBox.Show("Please provide a valid IP address.");
                return;
            }

            // Start the server on the provided IP address and port
            server = new TcpListener(IPAddress.Parse(ip), 5000);
            listenThread = new Thread(ListenForClients);
            listenThread.Start();

            txtMessages.AppendText("Server started...\r\n");

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string message = txtInput.Text;
            if (!string.IsNullOrEmpty(message))
            {
                BroadcastMessage("Server: " + message);
                txtMessages.AppendText("Server: " + message + "\r\n");
                txtInput.Clear();
            }
        }

        private void btnUpdateIP_Click(object sender, EventArgs e)
        {
            string newIP = txtServerIP.Text;
            if (server != null && server.Server.IsBound)
            {
                server.Stop();
                server = new TcpListener(IPAddress.Parse(newIP), 5000);
                listenThread = new Thread(ListenForClients);
                listenThread.Start();
                txtMessages.AppendText("IP Address updated and server restarted.\n");
            }
            else
            {
                MessageBox.Show("Server is not running.");
            }
        }

        private void frmServer_Load(object sender, EventArgs e)
        {
            txtServerIP.Text = GetLocalIPAddress();
        }

        private void frmServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopBroadcastingServer();
        }

        private void btnStopServer_Click(object sender, EventArgs e)
        {
            try
            {
                BroadcastMessage("System: Server is shutting down.");

                server?.Stop();

                StopBroadcastingServer();

                foreach (var client in clients)
                {
                    client?.Close();
                }

                clients.Clear();

                listenThread?.Interrupt();

                AppendChatBubble("System", "Server stopped.", isSystem: true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error stopping server: " + ex.Message);
            }
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
