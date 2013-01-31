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
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.domainTextBox = new System.Windows.Forms.TextBox();
			this.closeButton = new System.Windows.Forms.Button();
			this.domainLabel = new System.Windows.Forms.Label();
			this.mainMenu = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fileExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.accountGroupBox = new System.Windows.Forms.GroupBox();
			this.notifyMenu.SuspendLayout();
			this.mainMenu.SuspendLayout();
			this.accountGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// notifyIcon
			// 
			this.notifyIcon.ContextMenuStrip = this.notifyMenu;
			this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
			this.notifyIcon.Text = "Google Apps";
			this.notifyIcon.Visible = true;
			this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
			// 
			// notifyMenu
			// 
			this.notifyMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openGmailToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
			this.notifyMenu.Name = "notifyMenu";
			this.notifyMenu.Size = new System.Drawing.Size(140, 76);
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
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// domainTextBox
			// 
			this.domainTextBox.Location = new System.Drawing.Point(12, 44);
			this.domainTextBox.Name = "domainTextBox";
			this.domainTextBox.Size = new System.Drawing.Size(240, 20);
			this.domainTextBox.TabIndex = 1;
			this.domainTextBox.Text = "snapretail.com";
			// 
			// closeButton
			// 
			this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.closeButton.Location = new System.Drawing.Point(516, 274);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(100, 40);
			this.closeButton.TabIndex = 2;
			this.closeButton.Text = "&Close";
			this.closeButton.UseVisualStyleBackColor = true;
			this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
			// 
			// domainLabel
			// 
			this.domainLabel.AutoSize = true;
			this.domainLabel.Location = new System.Drawing.Point(12, 28);
			this.domainLabel.Name = "domainLabel";
			this.domainLabel.Size = new System.Drawing.Size(43, 13);
			this.domainLabel.TabIndex = 3;
			this.domainLabel.Text = "&Domain";
			// 
			// mainMenu
			// 
			this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.mainMenu.Location = new System.Drawing.Point(0, 0);
			this.mainMenu.Name = "mainMenu";
			this.mainMenu.Size = new System.Drawing.Size(624, 24);
			this.mainMenu.TabIndex = 4;
			this.mainMenu.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileExitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// fileExitToolStripMenuItem
			// 
			this.fileExitToolStripMenuItem.Name = "fileExitToolStripMenuItem";
			this.fileExitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
			this.fileExitToolStripMenuItem.Text = "E&xit";
			this.fileExitToolStripMenuItem.Click += new System.EventHandler(this.fileExitToolStripMenuItem_Click);
			// 
			// accountGroupBox
			// 
			this.accountGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.accountGroupBox.Controls.Add(this.domainLabel);
			this.accountGroupBox.Controls.Add(this.domainTextBox);
			this.accountGroupBox.Location = new System.Drawing.Point(8, 32);
			this.accountGroupBox.Name = "accountGroupBox";
			this.accountGroupBox.Size = new System.Drawing.Size(600, 104);
			this.accountGroupBox.TabIndex = 5;
			this.accountGroupBox.TabStop = false;
			this.accountGroupBox.Text = "Account Information";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(624, 320);
			this.Controls.Add(this.accountGroupBox);
			this.Controls.Add(this.closeButton);
			this.Controls.Add(this.mainMenu);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.mainMenu;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Google Apps Client";
			this.notifyMenu.ResumeLayout(false);
			this.mainMenu.ResumeLayout(false);
			this.mainMenu.PerformLayout();
			this.accountGroupBox.ResumeLayout(false);
			this.accountGroupBox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NotifyIcon notifyIcon;
		private System.Windows.Forms.ContextMenuStrip notifyMenu;
		private System.Windows.Forms.ToolStripMenuItem openGmailToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.TextBox domainTextBox;
		private System.Windows.Forms.Button closeButton;
		private System.Windows.Forms.Label domainLabel;
		private System.Windows.Forms.MenuStrip mainMenu;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileExitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
		private System.Windows.Forms.GroupBox accountGroupBox;
	}
}

