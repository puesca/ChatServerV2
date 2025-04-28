namespace frmClient
{
    partial class frmClient
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
            txtServerIP = new ComboBox();
            txtUsername = new TextBox();
            btnConnect = new Button();
            btnSetName = new Button();
            btnRefreshServers = new Button();
            btnSend = new Button();
            label1 = new Label();
            label2 = new Label();
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
            txtInput.Location = new Point(0, 371);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.ScrollBars = ScrollBars.Vertical;
            txtInput.Size = new Size(340, 53);
            txtInput.TabIndex = 1;
            txtInput.KeyDown += txtInput_KeyDown;
            // 
            // txtServerIP
            // 
            txtServerIP.FormattingEnabled = true;
            txtServerIP.Location = new Point(80, 306);
            txtServerIP.Name = "txtServerIP";
            txtServerIP.Size = new Size(121, 23);
            txtServerIP.TabIndex = 2;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(80, 335);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(121, 23);
            txtUsername.TabIndex = 3;
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(207, 305);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(47, 23);
            btnConnect.TabIndex = 4;
            btnConnect.Text = "Join";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // btnSetName
            // 
            btnSetName.Location = new Point(207, 334);
            btnSetName.Name = "btnSetName";
            btnSetName.Size = new Size(47, 23);
            btnSetName.TabIndex = 5;
            btnSetName.Text = "Save";
            btnSetName.UseVisualStyleBackColor = true;
            btnSetName.Click += btnSetName_Click;
            // 
            // btnRefreshServers
            // 
            btnRefreshServers.Location = new Point(260, 306);
            btnRefreshServers.Name = "btnRefreshServers";
            btnRefreshServers.Size = new Size(61, 23);
            btnRefreshServers.TabIndex = 6;
            btnRefreshServers.Text = "Refresh";
            btnRefreshServers.UseVisualStyleBackColor = true;
            btnRefreshServers.Click += btnRefreshServers_Click;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(260, 334);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(61, 23);
            btnSend.TabIndex = 7;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 309);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 8;
            label1.Text = "Server IP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 338);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 9;
            label2.Text = "User Name";
            // 
            // frmClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 424);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSend);
            Controls.Add(btnRefreshServers);
            Controls.Add(btnSetName);
            Controls.Add(btnConnect);
            Controls.Add(txtUsername);
            Controls.Add(txtServerIP);
            Controls.Add(txtInput);
            Controls.Add(txtMessages);
            Name = "frmClient";
            Text = "Form Client";
            FormClosing += frmClient_FormClosing;
            Load += frmClient_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtMessages;
        private TextBox txtInput;
        private ComboBox txtServerIP;
        private TextBox txtUsername;
        private Button btnConnect;
        private Button btnSetName;
        private Button btnRefreshServers;
        private Button btnSend;
        private Label label1;
        private Label label2;
    }
}
