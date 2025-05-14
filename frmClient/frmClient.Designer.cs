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
            label1 = new Label();
            label2 = new Label();
            hopeForm1 = new ReaLTaiizor.Forms.HopeForm();
            txtServerIP = new ReaLTaiizor.Controls.DungeonComboBox();
            txtUsername = new ReaLTaiizor.Controls.DungeonTextBox();
            btnSend = new ReaLTaiizor.Controls.HopeButton();
            btnSetName = new ReaLTaiizor.Controls.DungeonButtonLeft();
            btnConnect = new ReaLTaiizor.Controls.DungeonButtonLeft();
            btnRefreshServers = new ReaLTaiizor.Controls.DungeonButtonLeft();
            txtMessages = new FlowLayoutPanel();
            txtInput = new ReaLTaiizor.Controls.PoisonTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 414);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 8;
            label1.Text = "Server IP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 383);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 9;
            label2.Text = "User Name";
            // 
            // hopeForm1
            // 
            hopeForm1.ControlBoxColorH = Color.FromArgb(228, 231, 237);
            hopeForm1.ControlBoxColorHC = Color.FromArgb(245, 108, 108);
            hopeForm1.ControlBoxColorN = Color.White;
            hopeForm1.Dock = DockStyle.Top;
            hopeForm1.Font = new Font("Segoe UI", 12F);
            hopeForm1.ForeColor = Color.FromArgb(242, 246, 252);
            hopeForm1.Image = null;
            hopeForm1.Location = new Point(0, 0);
            hopeForm1.Name = "hopeForm1";
            hopeForm1.Size = new Size(343, 40);
            hopeForm1.TabIndex = 10;
            hopeForm1.Text = "Client Form";
            hopeForm1.ThemeColor = Color.Green;
            // 
            // txtServerIP
            // 
            txtServerIP.BackColor = Color.FromArgb(246, 246, 246);
            txtServerIP.ColorA = Color.FromArgb(246, 132, 85);
            txtServerIP.ColorB = Color.FromArgb(231, 108, 57);
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
            txtServerIP.ForeColor = Color.FromArgb(76, 76, 97);
            txtServerIP.FormattingEnabled = true;
            txtServerIP.HoverSelectionColor = Color.Empty;
            txtServerIP.IntegralHeight = false;
            txtServerIP.ItemHeight = 20;
            txtServerIP.Location = new Point(79, 409);
            txtServerIP.Name = "txtServerIP";
            txtServerIP.Size = new Size(160, 26);
            txtServerIP.StartIndex = 0;
            txtServerIP.TabIndex = 12;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.Transparent;
            txtUsername.BorderColor = Color.FromArgb(180, 180, 180);
            txtUsername.EdgeColor = Color.White;
            txtUsername.Font = new Font("Tahoma", 11F);
            txtUsername.ForeColor = Color.DimGray;
            txtUsername.Location = new Point(79, 379);
            txtUsername.MaxLength = 32767;
            txtUsername.Multiline = false;
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = false;
            txtUsername.Size = new Size(160, 28);
            txtUsername.TabIndex = 13;
            txtUsername.TextAlignment = HorizontalAlignment.Left;
            txtUsername.UseSystemPasswordChar = false;
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
            btnSend.Location = new Point(286, 441);
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
            btnSetName.Location = new Point(40, 471);
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
            // btnConnect
            // 
            btnConnect.BackColor = Color.Transparent;
            btnConnect.BorderColor = Color.FromArgb(180, 180, 180);
            btnConnect.Font = new Font("Segoe UI", 12F);
            btnConnect.Image = null;
            btnConnect.ImageAlign = ContentAlignment.MiddleLeft;
            btnConnect.InactiveColorA = Color.FromArgb(253, 252, 252);
            btnConnect.InactiveColorB = Color.FromArgb(239, 237, 236);
            btnConnect.Location = new Point(245, 409);
            btnConnect.Name = "btnConnect";
            btnConnect.PressedColorA = Color.FromArgb(226, 226, 226);
            btnConnect.PressedColorB = Color.FromArgb(237, 237, 237);
            btnConnect.PressedContourColorA = Color.FromArgb(167, 167, 167);
            btnConnect.PressedContourColorB = Color.FromArgb(167, 167, 167);
            btnConnect.Size = new Size(51, 26);
            btnConnect.TabIndex = 17;
            btnConnect.Text = "Join";
            btnConnect.TextAlignment = StringAlignment.Center;
            btnConnect.Click += btnConnect_Click;
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
            btnRefreshServers.Location = new Point(62, 471);
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
            txtMessages.Dock = DockStyle.Top;
            txtMessages.FlowDirection = FlowDirection.TopDown;
            txtMessages.Location = new Point(0, 40);
            txtMessages.Name = "txtMessages";
            txtMessages.Size = new Size(343, 333);
            txtMessages.TabIndex = 19;
            txtMessages.WrapContents = false;
            // 
            // txtInput
            // 
            // 
            // 
            // 
            txtInput.CustomButton.Image = null;
            txtInput.CustomButton.Location = new Point(226, 2);
            txtInput.CustomButton.Name = "";
            txtInput.CustomButton.Size = new Size(39, 39);
            txtInput.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            txtInput.CustomButton.TabIndex = 1;
            txtInput.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            txtInput.CustomButton.UseSelectable = true;
            txtInput.CustomButton.Visible = false;
            txtInput.Location = new Point(12, 442);
            txtInput.MaxLength = 32767;
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.PasswordChar = '\0';
            txtInput.ScrollBars = ScrollBars.Vertical;
            txtInput.SelectedText = "";
            txtInput.SelectionLength = 0;
            txtInput.SelectionStart = 0;
            txtInput.ShortcutsEnabled = true;
            txtInput.Size = new Size(268, 44);
            txtInput.TabIndex = 20;
            txtInput.UseSelectable = true;
            txtInput.WaterMarkColor = Color.FromArgb(109, 109, 109);
            txtInput.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            txtInput.KeyDown += txtInput_KeyDown;
            // 
            // frmClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(343, 493);
            Controls.Add(txtMessages);
            Controls.Add(txtInput);
            Controls.Add(btnConnect);
            Controls.Add(btnSend);
            Controls.Add(txtUsername);
            Controls.Add(txtServerIP);
            Controls.Add(hopeForm1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRefreshServers);
            Controls.Add(btnSetName);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1920, 1032);
            MinimumSize = new Size(190, 40);
            Name = "frmClient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form Client";
            TransparencyKey = Color.Fuchsia;
            FormClosing += frmClient_FormClosing;
            Load += frmClient_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private ReaLTaiizor.Forms.HopeForm hopeForm1;
        private ReaLTaiizor.Controls.DungeonComboBox txtServerIP;
        private ReaLTaiizor.Controls.DungeonTextBox txtUsername;
        private ReaLTaiizor.Controls.HopeButton btnSend;
        private ReaLTaiizor.Controls.DungeonButtonLeft btnSetName;
        private ReaLTaiizor.Controls.DungeonButtonLeft btnConnect;
        private ReaLTaiizor.Controls.DungeonButtonLeft btnRefreshServers;
        private FlowLayoutPanel txtMessages;
        private ReaLTaiizor.Controls.PoisonTextBox txtInput;
    }
}
