namespace GoogleAppsClient {
	partial class MainForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.notifyMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.openGmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.closeButton = new System.Windows.Forms.Button();
			this.mainMenu = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fileOpenGmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.fileExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpAboutGoogleAppsClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.calendarNotificationsCheckBox = new System.Windows.Forms.CheckBox();
			this.emailNotificationsCheckBox = new System.Windows.Forms.CheckBox();
			this.loginButton = new System.Windows.Forms.Button();
			this.iconImageList = new System.Windows.Forms.ImageList(this.components);
			this.newEmailCountCheckBox = new System.Windows.Forms.CheckBox();
			this.checkTimer = new System.Windows.Forms.Timer(this.components);
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.loginPanel = new System.Windows.Forms.Panel();
			this.statusLabel = new System.Windows.Forms.Label();
			this.logoutButton = new System.Windows.Forms.Button();
			this.notifyMenu.SuspendLayout();
			this.mainMenu.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.loginPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// notifyIcon
			// 
			this.notifyIcon.ContextMenuStrip = this.notifyMenu;
			this.notifyIcon.Text = "Offline - Google Apps Client";
			this.notifyIcon.Visible = true;
			this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
			// 
			// notifyMenu
			// 
			this.notifyMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openGmailToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.aboutToolStripMenuItem,
            this.toolStripMenuItem3,
            this.exitToolStripMenuItem});
			this.notifyMenu.Name = "notifyMenu";
			this.notifyMenu.Size = new System.Drawing.Size(140, 104);
			// 
			// openGmailToolStripMenuItem
			// 
			this.openGmailToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.openGmailToolStripMenuItem.Name = "openGmailToolStripMenuItem";
			this.openGmailToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
			this.openGmailToolStripMenuItem.Text = "Open Gmail";
			this.openGmailToolStripMenuItem.Click += new System.EventHandler(this.openGmailToolStripMenuItem_Click);
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
			this.settingsToolStripMenuItem.Text = "&Settings...";
			this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(136, 6);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(136, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// closeButton
			// 
			this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.closeButton.Location = new System.Drawing.Point(384, 272);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(100, 40);
			this.closeButton.TabIndex = 5;
			this.closeButton.Text = "&Close";
			this.closeButton.UseVisualStyleBackColor = true;
			this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
			// 
			// mainMenu
			// 
			this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.mainMenu.Location = new System.Drawing.Point(0, 0);
			this.mainMenu.Name = "mainMenu";
			this.mainMenu.Size = new System.Drawing.Size(492, 24);
			this.mainMenu.TabIndex = 0;
			this.mainMenu.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileOpenGmailToolStripMenuItem,
            this.toolStripMenuItem2,
            this.fileExitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// fileOpenGmailToolStripMenuItem
			// 
			this.fileOpenGmailToolStripMenuItem.Name = "fileOpenGmailToolStripMenuItem";
			this.fileOpenGmailToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
			this.fileOpenGmailToolStripMenuItem.Text = "Open &Gmail";
			this.fileOpenGmailToolStripMenuItem.Click += new System.EventHandler(this.fileOpenGmailToolStripMenuItem_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(134, 6);
			// 
			// fileExitToolStripMenuItem
			// 
			this.fileExitToolStripMenuItem.Name = "fileExitToolStripMenuItem";
			this.fileExitToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
			this.fileExitToolStripMenuItem.Text = "E&xit";
			this.fileExitToolStripMenuItem.Click += new System.EventHandler(this.fileExitToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpAboutGoogleAppsClientToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// helpAboutGoogleAppsClientToolStripMenuItem
			// 
			this.helpAboutGoogleAppsClientToolStripMenuItem.Name = "helpAboutGoogleAppsClientToolStripMenuItem";
			this.helpAboutGoogleAppsClientToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
			this.helpAboutGoogleAppsClientToolStripMenuItem.Text = "&About Google Apps Client";
			this.helpAboutGoogleAppsClientToolStripMenuItem.Click += new System.EventHandler(this.helpAboutGoogleAppsClientToolStripMenuItem_Click);
			// 
			// calendarNotificationsCheckBox
			// 
			this.calendarNotificationsCheckBox.AutoSize = true;
			this.calendarNotificationsCheckBox.Checked = true;
			this.calendarNotificationsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.calendarNotificationsCheckBox.Location = new System.Drawing.Point(12, 72);
			this.calendarNotificationsCheckBox.Name = "calendarNotificationsCheckBox";
			this.calendarNotificationsCheckBox.Size = new System.Drawing.Size(127, 17);
			this.calendarNotificationsCheckBox.TabIndex = 4;
			this.calendarNotificationsCheckBox.Text = "&Calendar notifications";
			this.calendarNotificationsCheckBox.UseVisualStyleBackColor = true;
			this.calendarNotificationsCheckBox.Visible = false;
			// 
			// emailNotificationsCheckBox
			// 
			this.emailNotificationsCheckBox.AutoSize = true;
			this.emailNotificationsCheckBox.Checked = true;
			this.emailNotificationsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.emailNotificationsCheckBox.Location = new System.Drawing.Point(12, 48);
			this.emailNotificationsCheckBox.Name = "emailNotificationsCheckBox";
			this.emailNotificationsCheckBox.Size = new System.Drawing.Size(110, 17);
			this.emailNotificationsCheckBox.TabIndex = 3;
			this.emailNotificationsCheckBox.Text = "&Email notifications";
			this.emailNotificationsCheckBox.UseVisualStyleBackColor = true;
			this.emailNotificationsCheckBox.Visible = false;
			// 
			// loginButton
			// 
			this.loginButton.Dock = System.Windows.Forms.DockStyle.Right;
			this.loginButton.Location = new System.Drawing.Point(368, 0);
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new System.Drawing.Size(100, 40);
			this.loginButton.TabIndex = 8;
			this.loginButton.Text = "&Login";
			this.loginButton.UseVisualStyleBackColor = true;
			this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
			// 
			// iconImageList
			// 
			this.iconImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconImageList.ImageStream")));
			this.iconImageList.TransparentColor = System.Drawing.Color.Transparent;
			this.iconImageList.Images.SetKeyName(0, "offline.png");
			this.iconImageList.Images.SetKeyName(1, "nomail.png");
			this.iconImageList.Images.SetKeyName(2, "newmail-basic.png");
			this.iconImageList.Images.SetKeyName(3, "newmail-count.png");
			// 
			// newEmailCountCheckBox
			// 
			this.newEmailCountCheckBox.AutoSize = true;
			this.newEmailCountCheckBox.Checked = true;
			this.newEmailCountCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.newEmailCountCheckBox.Location = new System.Drawing.Point(12, 24);
			this.newEmailCountCheckBox.Name = "newEmailCountCheckBox";
			this.newEmailCountCheckBox.Size = new System.Drawing.Size(109, 17);
			this.newEmailCountCheckBox.TabIndex = 2;
			this.newEmailCountCheckBox.Text = "\'New email\' &count";
			this.newEmailCountCheckBox.UseVisualStyleBackColor = true;
			this.newEmailCountCheckBox.CheckedChanged += new System.EventHandler(this.newEmailCountCheckBox_CheckedChanged);
			// 
			// checkTimer
			// 
			this.checkTimer.Interval = 10000;
			this.checkTimer.Tick += new System.EventHandler(this.checkTimer_Tick);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.newEmailCountCheckBox);
			this.groupBox1.Controls.Add(this.emailNotificationsCheckBox);
			this.groupBox1.Controls.Add(this.calendarNotificationsCheckBox);
			this.groupBox1.Location = new System.Drawing.Point(16, 84);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(468, 108);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "&Options";
			// 
			// loginPanel
			// 
			this.loginPanel.Controls.Add(this.statusLabel);
			this.loginPanel.Controls.Add(this.logoutButton);
			this.loginPanel.Controls.Add(this.loginButton);
			this.loginPanel.Location = new System.Drawing.Point(16, 32);
			this.loginPanel.Name = "loginPanel";
			this.loginPanel.Size = new System.Drawing.Size(468, 40);
			this.loginPanel.TabIndex = 12;
			// 
			// statusLabel
			// 
			this.statusLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.statusLabel.Location = new System.Drawing.Point(0, 0);
			this.statusLabel.Name = "statusLabel";
			this.statusLabel.Size = new System.Drawing.Size(268, 40);
			this.statusLabel.TabIndex = 15;
			this.statusLabel.Text = "Status";
			this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// logoutButton
			// 
			this.logoutButton.Dock = System.Windows.Forms.DockStyle.Right;
			this.logoutButton.Location = new System.Drawing.Point(268, 0);
			this.logoutButton.Name = "logoutButton";
			this.logoutButton.Size = new System.Drawing.Size(100, 40);
			this.logoutButton.TabIndex = 16;
			this.logoutButton.Text = "&Logout";
			this.logoutButton.UseVisualStyleBackColor = true;
			this.logoutButton.Visible = false;
			this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(492, 320);
			this.Controls.Add(this.loginPanel);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.closeButton);
			this.Controls.Add(this.mainMenu);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.mainMenu;
			this.MinimumSize = new System.Drawing.Size(320, 242);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Google Apps Client";
			this.Shown += new System.EventHandler(this.MainForm_Shown);
			this.notifyMenu.ResumeLayout(false);
			this.mainMenu.ResumeLayout(false);
			this.mainMenu.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.loginPanel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NotifyIcon notifyIcon;
		private System.Windows.Forms.ContextMenuStrip notifyMenu;
		private System.Windows.Forms.ToolStripMenuItem openGmailToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.Button closeButton;
		private System.Windows.Forms.MenuStrip mainMenu;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileExitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
		private System.Windows.Forms.CheckBox calendarNotificationsCheckBox;
		private System.Windows.Forms.CheckBox emailNotificationsCheckBox;
		private System.Windows.Forms.ToolStripMenuItem fileOpenGmailToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ImageList iconImageList;
		private System.Windows.Forms.CheckBox newEmailCountCheckBox;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpAboutGoogleAppsClientToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
		private System.Windows.Forms.Timer checkTimer;
		private System.Windows.Forms.Button loginButton;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Panel loginPanel;
		private System.Windows.Forms.Label statusLabel;
		private System.Windows.Forms.Button logoutButton;
	}
}

