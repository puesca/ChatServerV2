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
            hopeForm1 = new ReaLTaiizor.Forms.HopeForm();
            btnSend = new ReaLTaiizor.Controls.HopeButton();
            btnSetName = new ReaLTaiizor.Controls.DungeonButtonLeft();
            btnRefreshServers = new ReaLTaiizor.Controls.DungeonButtonLeft();
            txtMessages = new FlowLayoutPanel();
            poisonTabControl1 = new ReaLTaiizor.Controls.PoisonTabControl();
            tabPage1 = new TabPage();
            txtInput = new ReaLTaiizor.Controls.DreamTextBox();
            tabPage2 = new TabPage();
            txtUsername = new ReaLTaiizor.Controls.DreamTextBox();
            label2 = new Label();
            btnConnect = new ReaLTaiizor.Controls.DungeonButtonLeft();
            label1 = new Label();
            txtServerIP = new ReaLTaiizor.Controls.DungeonComboBox();
            label3 = new Label();
            swtMode = new ReaLTaiizor.Controls.HopeSwitch();
            poisonTabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // hopeForm1
            // 
            hopeForm1.BackColor = Color.White;
            hopeForm1.ControlBoxColorH = Color.FromArgb(228, 231, 237);
            hopeForm1.ControlBoxColorHC = Color.FromArgb(245, 108, 108);
            hopeForm1.ControlBoxColorN = Color.White;
            hopeForm1.Dock = DockStyle.Top;
            hopeForm1.Font = new Font("Segoe UI", 12F);
            hopeForm1.ForeColor = Color.FromArgb(242, 246, 252);
            hopeForm1.Image = null;
            hopeForm1.Location = new Point(0, 0);
            hopeForm1.Name = "hopeForm1";
            hopeForm1.Size = new Size(355, 40);
            hopeForm1.TabIndex = 10;
            hopeForm1.Text = "Client Form";
            hopeForm1.ThemeColor = Color.Green;
            // 
            // btnSend
            // 
            btnSend.BorderColor = Color.FromArgb(220, 223, 230);
            btnSend.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnSend.DangerColor = Color.FromArgb(245, 108, 108);
            btnSend.DefaultColor = Color.FromArgb(255, 255, 255);
            btnSend.Font = new Font("Segoe UI", 12F);
            btnSend.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnSend.InfoColor = Color.FromArgb(144, 147, 153);
            btnSend.Location = new Point(287, 363);
            btnSend.Name = "btnSend";
            btnSend.PrimaryColor = Color.FromArgb(64, 158, 255);
            btnSend.Size = new Size(54, 49);
            btnSend.SuccessColor = Color.FromArgb(103, 194, 58);
            btnSend.TabIndex = 15;
            btnSend.Text = "Send";
            btnSend.TextColor = Color.White;
            btnSend.WarningColor = Color.FromArgb(230, 162, 60);
            btnSend.Click += btnSend_Click;
            // 
            // btnSetName
            // 
            btnSetName.BackColor = Color.Transparent;
            btnSetName.BorderColor = Color.FromArgb(180, 180, 180);
            btnSetName.Font = new Font("Segoe UI", 12F);
            btnSetName.Image = null;
            btnSetName.ImageAlign = ContentAlignment.MiddleLeft;
            btnSetName.InactiveColorA = Color.FromArgb(253, 252, 252);
            btnSetName.InactiveColorB = Color.FromArgb(239, 237, 236);
            btnSetName.Location = new Point(41, 393);
            btnSetName.Name = "btnSetName";
            btnSetName.PressedColorA = Color.FromArgb(226, 226, 226);
            btnSetName.PressedColorB = Color.FromArgb(237, 237, 237);
            btnSetName.PressedContourColorA = Color.FromArgb(167, 167, 167);
            btnSetName.PressedContourColorB = Color.FromArgb(167, 167, 167);
            btnSetName.Size = new Size(19, 10);
            btnSetName.TabIndex = 16;
            btnSetName.Text = "Save";
            btnSetName.TextAlignment = StringAlignment.Center;
            btnSetName.Visible = false;
            btnSetName.Click += btnSetName_Click;
            // 
            // btnRefreshServers
            // 
            btnRefreshServers.BackColor = Color.Transparent;
            btnRefreshServers.BorderColor = Color.FromArgb(180, 180, 180);
            btnRefreshServers.Font = new Font("Segoe UI", 12F);
            btnRefreshServers.Image = null;
            btnRefreshServers.ImageAlign = ContentAlignment.MiddleLeft;
            btnRefreshServers.InactiveColorA = Color.FromArgb(253, 252, 252);
            btnRefreshServers.InactiveColorB = Color.FromArgb(239, 237, 236);
            btnRefreshServers.Location = new Point(63, 393);
            btnRefreshServers.Name = "btnRefreshServers";
            btnRefreshServers.PressedColorA = Color.FromArgb(226, 226, 226);
            btnRefreshServers.PressedColorB = Color.FromArgb(237, 237, 237);
            btnRefreshServers.PressedContourColorA = Color.FromArgb(167, 167, 167);
            btnRefreshServers.PressedContourColorB = Color.FromArgb(167, 167, 167);
            btnRefreshServers.Size = new Size(28, 10);
            btnRefreshServers.TabIndex = 18;
            btnRefreshServers.Text = "Refresh";
            btnRefreshServers.TextAlignment = StringAlignment.Center;
            btnRefreshServers.Visible = false;
            btnRefreshServers.Click += btnRefreshServers_Click;
            // 
            // txtMessages
            // 
            txtMessages.AutoScroll = true;
            txtMessages.BackColor = Color.White;
            txtMessages.BorderStyle = BorderStyle.Fixed3D;
            txtMessages.Dock = DockStyle.Top;
            txtMessages.FlowDirection = FlowDirection.TopDown;
            txtMessages.Location = new Point(3, 3);
            txtMessages.Name = "txtMessages";
            txtMessages.Size = new Size(341, 354);
            txtMessages.TabIndex = 19;
            txtMessages.WrapContents = false;
            // 
            // poisonTabControl1
            // 
            poisonTabControl1.Controls.Add(tabPage1);
            poisonTabControl1.Controls.Add(tabPage2);
            poisonTabControl1.Dock = DockStyle.Fill;
            poisonTabControl1.Location = new Point(0, 40);
            poisonTabControl1.Name = "poisonTabControl1";
            poisonTabControl1.Padding = new Point(6, 8);
            poisonTabControl1.SelectedIndex = 0;
            poisonTabControl1.Size = new Size(355, 453);
            poisonTabControl1.TabIndex = 21;
            poisonTabControl1.UseSelectable = true;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtInput);
            tabPage1.Controls.Add(txtMessages);
            tabPage1.Controls.Add(btnSetName);
            tabPage1.Controls.Add(btnSend);
            tabPage1.Controls.Add(btnRefreshServers);
            tabPage1.Location = new Point(4, 38);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(347, 411);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Chats";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtInput
            // 
            txtInput.BackColor = Color.WhiteSmoke;
            txtInput.BorderStyle = BorderStyle.FixedSingle;
            txtInput.ColorA = Color.FromArgb(31, 31, 31);
            txtInput.ColorB = Color.FromArgb(41, 41, 41);
            txtInput.ColorC = Color.FromArgb(51, 51, 51);
            txtInput.ColorD = Color.FromArgb(0, 0, 0, 0);
            txtInput.ColorE = Color.FromArgb(25, 255, 255, 255);
            txtInput.ColorF = Color.Transparent;
            txtInput.ForeColor = Color.Black;
            txtInput.Location = new Point(3, 363);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.ScrollBars = ScrollBars.Vertical;
            txtInput.Size = new Size(278, 46);
            txtInput.TabIndex = 22;
            txtInput.KeyDown += txtInput_KeyDown;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(txtUsername);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(btnConnect);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(txtServerIP);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(swtMode);
            tabPage2.Location = new Point(4, 38);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(347, 411);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Option(s)";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.WhiteSmoke;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.ColorA = Color.FromArgb(31, 31, 31);
            txtUsername.ColorB = Color.FromArgb(41, 41, 41);
            txtUsername.ColorC = Color.FromArgb(51, 51, 51);
            txtUsername.ColorD = Color.FromArgb(0, 0, 0, 0);
            txtUsername.ColorE = Color.FromArgb(25, 255, 255, 255);
            txtUsername.ColorF = Color.Transparent;
            txtUsername.ForeColor = Color.Black;
            txtUsername.Location = new Point(75, 6);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(161, 23);
            txtUsername.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 9);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 25;
            label2.Text = "User Name";
            // 
            // btnConnect
            // 
            btnConnect.BackColor = Color.Transparent;
            btnConnect.BorderColor = Color.FromArgb(180, 180, 180);
            btnConnect.Font = new Font("Segoe UI", 12F);
            btnConnect.Image = null;
            btnConnect.ImageAlign = ContentAlignment.MiddleLeft;
            btnConnect.InactiveColorA = Color.FromArgb(253, 252, 252);
            btnConnect.InactiveColorB = Color.FromArgb(239, 237, 236);
            btnConnect.Location = new Point(242, 35);
            btnConnect.Name = "btnConnect";
            btnConnect.PressedColorA = Color.FromArgb(226, 226, 226);
            btnConnect.PressedColorB = Color.FromArgb(237, 237, 237);
            btnConnect.PressedContourColorA = Color.FromArgb(167, 167, 167);
            btnConnect.PressedContourColorB = Color.FromArgb(167, 167, 167);
            btnConnect.Size = new Size(51, 26);
            btnConnect.TabIndex = 27;
            btnConnect.Text = "Join";
            btnConnect.TextAlignment = StringAlignment.Center;
            btnConnect.Click += btnConnect_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 40);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 24;
            label1.Text = "Server IP";
            // 
            // txtServerIP
            // 
            txtServerIP.BackColor = Color.FromArgb(246, 246, 246);
            txtServerIP.ColorA = Color.White;
            txtServerIP.ColorB = Color.Transparent;
            txtServerIP.ColorC = Color.FromArgb(242, 241, 240);
            txtServerIP.ColorD = Color.FromArgb(253, 252, 252);
            txtServerIP.ColorE = Color.FromArgb(239, 237, 236);
            txtServerIP.ColorF = Color.FromArgb(180, 180, 180);
            txtServerIP.ColorG = Color.FromArgb(119, 119, 118);
            txtServerIP.ColorH = Color.FromArgb(224, 222, 220);
            txtServerIP.ColorI = Color.FromArgb(250, 249, 249);
            txtServerIP.DrawMode = DrawMode.OwnerDrawFixed;
            txtServerIP.DropDownHeight = 100;
            txtServerIP.DropDownStyle = ComboBoxStyle.DropDownList;
            txtServerIP.Font = new Font("Segoe UI", 10F);
            txtServerIP.ForeColor = Color.Black;
            txtServerIP.FormattingEnabled = true;
            txtServerIP.HoverSelectionColor = Color.Empty;
            txtServerIP.IntegralHeight = false;
            txtServerIP.ItemHeight = 20;
            txtServerIP.Location = new Point(76, 35);
            txtServerIP.Name = "txtServerIP";
            txtServerIP.Size = new Size(160, 26);
            txtServerIP.StartIndex = 0;
            txtServerIP.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 69);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 10;
            label3.Text = "Switch Mode";
            // 
            // swtMode
            // 
            swtMode.AutoSize = true;
            swtMode.BaseColor = Color.White;
            swtMode.BaseOffColor = Color.FromArgb(220, 223, 230);
            swtMode.BaseOnColor = Color.FromArgb(64, 158, 255);
            swtMode.ForeColor = Color.Transparent;
            swtMode.Location = new Point(100, 67);
            swtMode.Name = "swtMode";
            swtMode.Size = new Size(40, 20);
            swtMode.TabIndex = 0;
            swtMode.Text = "hopeSwitch1";
            swtMode.UseVisualStyleBackColor = true;
            swtMode.CheckedChanged += swtMode_CheckedChanged;
            // 
            // frmClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(355, 493);
            Controls.Add(poisonTabControl1);
            Controls.Add(hopeForm1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1920, 1032);
            MinimumSize = new Size(190, 40);
            Name = "frmClient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form Client";
            TransparencyKey = Color.Fuchsia;
            FormClosing += frmClient_FormClosing;
            Load += frmClient_Load;
            poisonTabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Forms.HopeForm hopeForm1;
        private ReaLTaiizor.Controls.HopeButton btnSend;
        private ReaLTaiizor.Controls.DungeonButtonLeft btnSetName;
        private ReaLTaiizor.Controls.DungeonButtonLeft btnRefreshServers;
        private FlowLayoutPanel txtMessages;
        private ReaLTaiizor.Controls.PoisonTabControl poisonTabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ReaLTaiizor.Controls.HopeSwitch swtMode;
        private Label label3;
        private ReaLTaiizor.Controls.DreamTextBox txtInput;
        private ReaLTaiizor.Controls.DreamTextBox txtUsername;
        private Label label2;
        private ReaLTaiizor.Controls.DungeonButtonLeft btnConnect;
        private Label label1;
        private ReaLTaiizor.Controls.DungeonComboBox txtServerIP;
    }
}
