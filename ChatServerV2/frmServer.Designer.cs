namespace ChatServerV2
{
    partial class frmServer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtMessages = new RichTextBox();
            txtInput = new TextBox();
            txtServerIP = new TextBox();
            btnStopServer = new Button();
            btnStartServer = new Button();
            btnUpdateIP = new Button();
            btnSend = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtMessages
            // 
            txtMessages.Dock = DockStyle.Top;
            txtMessages.Location = new Point(0, 0);
            txtMessages.Name = "txtMessages";
            txtMessages.ReadOnly = true;
            txtMessages.ScrollBars = RichTextBoxScrollBars.Vertical;
            txtMessages.Size = new Size(340, 300);
            txtMessages.TabIndex = 0;
            txtMessages.Text = "";
            // 
            // txtInput
            // 
            txtInput.Dock = DockStyle.Bottom;
            txtInput.Location = new Point(0, 374);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.ScrollBars = ScrollBars.Vertical;
            txtInput.Size = new Size(340, 50);
            txtInput.TabIndex = 1;
            txtInput.KeyDown += txtInput_KeyDown;
            // 
            // txtServerIP
            // 
            txtServerIP.Location = new Point(70, 306);
            txtServerIP.Name = "txtServerIP";
            txtServerIP.Size = new Size(100, 23);
            txtServerIP.TabIndex = 2;
            // 
            // btnStopServer
            // 
            btnStopServer.Location = new Point(176, 306);
            btnStopServer.Name = "btnStopServer";
            btnStopServer.Size = new Size(75, 23);
            btnStopServer.TabIndex = 3;
            btnStopServer.Text = "Stop Server";
            btnStopServer.UseVisualStyleBackColor = true;
            btnStopServer.Click += btnStopServer_Click;
            // 
            // btnStartServer
            // 
            btnStartServer.Location = new Point(12, 345);
            btnStartServer.Name = "btnStartServer";
            btnStartServer.Size = new Size(75, 23);
            btnStartServer.TabIndex = 4;
            btnStartServer.Text = "Start Server";
            btnStartServer.UseVisualStyleBackColor = true;
            btnStartServer.Click += btnStartServer_Click;
            // 
            // btnUpdateIP
            // 
            btnUpdateIP.Location = new Point(93, 345);
            btnUpdateIP.Name = "btnUpdateIP";
            btnUpdateIP.Size = new Size(75, 23);
            btnUpdateIP.TabIndex = 5;
            btnUpdateIP.Text = "Update Server";
            btnUpdateIP.UseVisualStyleBackColor = true;
            btnUpdateIP.Click += btnUpdateIP_Click;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(265, 345);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(75, 23);
            btnSend.TabIndex = 6;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 310);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 7;
            label1.Text = "Server IP";
            // 
            // frmServer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 424);
            Controls.Add(label1);
            Controls.Add(btnSend);
            Controls.Add(btnUpdateIP);
            Controls.Add(btnStartServer);
            Controls.Add(btnStopServer);
            Controls.Add(txtServerIP);
            Controls.Add(txtInput);
            Controls.Add(txtMessages);
            Name = "frmServer";
            Text = "Server Form";
            FormClosing += frmServer_FormClosing;
            Load += frmServer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtMessages;
        private TextBox txtInput;
        private TextBox txtServerIP;
        private Button btnStopServer;
        private Button btnStartServer;
        private Button btnUpdateIP;
        private Button btnSend;
        private Label label1;
    }
}
