namespace GoogleAppsClient {
	partial class LoginForm {
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
			this.usernameTextBox = new System.Windows.Forms.TextBox();
			this.passwordLabel = new System.Windows.Forms.Label();
			this.usernameLabel = new System.Windows.Forms.Label();
			this.passwordTextBox = new System.Windows.Forms.TextBox();
			this.loginButton = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.savePasswordCheckBox = new System.Windows.Forms.CheckBox();
			this.usernamePanel = new System.Windows.Forms.Panel();
			this.domainLabel = new System.Windows.Forms.Label();
			this.usernamePanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// usernameTextBox
			// 
			this.usernameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.usernameTextBox.Location = new System.Drawing.Point(0, 0);
			this.usernameTextBox.Name = "usernameTextBox";
			this.usernameTextBox.Size = new System.Drawing.Size(278, 20);
			this.usernameTextBox.TabIndex = 0;
			this.usernameTextBox.TextChanged += new System.EventHandler(this.usernameTextBox_TextChanged);
			// 
			// passwordLabel
			// 
			this.passwordLabel.AutoSize = true;
			this.passwordLabel.Location = new System.Drawing.Point(12, 44);
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.Size = new System.Drawing.Size(56, 13);
			this.passwordLabel.TabIndex = 2;
			this.passwordLabel.Text = "&Password:";
			// 
			// usernameLabel
			// 
			this.usernameLabel.AutoSize = true;
			this.usernameLabel.Location = new System.Drawing.Point(12, 16);
			this.usernameLabel.Name = "usernameLabel";
			this.usernameLabel.Size = new System.Drawing.Size(58, 13);
			this.usernameLabel.TabIndex = 0;
			this.usernameLabel.Text = "&Username:";
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.passwordTextBox.Location = new System.Drawing.Point(76, 40);
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.PasswordChar = '*';
			this.passwordTextBox.Size = new System.Drawing.Size(296, 20);
			this.passwordTextBox.TabIndex = 3;
			this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
			this.passwordTextBox.Enter += new System.EventHandler(this.passwordTextBox_Enter);
			// 
			// loginButton
			// 
			this.loginButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.loginButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.loginButton.Location = new System.Drawing.Point(168, 104);
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new System.Drawing.Size(100, 36);
			this.loginButton.TabIndex = 5;
			this.loginButton.Text = "&Login";
			this.loginButton.UseVisualStyleBackColor = true;
			// 
			// buttonCancel
			// 
			this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(276, 104);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(100, 36);
			this.buttonCancel.TabIndex = 6;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// savePasswordCheckBox
			// 
			this.savePasswordCheckBox.AutoSize = true;
			this.savePasswordCheckBox.Checked = true;
			this.savePasswordCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.savePasswordCheckBox.Location = new System.Drawing.Point(76, 68);
			this.savePasswordCheckBox.Name = "savePasswordCheckBox";
			this.savePasswordCheckBox.Size = new System.Drawing.Size(99, 17);
			this.savePasswordCheckBox.TabIndex = 4;
			this.savePasswordCheckBox.Text = "&Save password";
			this.savePasswordCheckBox.UseVisualStyleBackColor = true;
			// 
			// usernamePanel
			// 
			this.usernamePanel.Controls.Add(this.usernameTextBox);
			this.usernamePanel.Controls.Add(this.domainLabel);
			this.usernamePanel.Location = new System.Drawing.Point(76, 12);
			this.usernamePanel.Name = "usernamePanel";
			this.usernamePanel.Size = new System.Drawing.Size(296, 20);
			this.usernamePanel.TabIndex = 1;
			// 
			// domainLabel
			// 
			this.domainLabel.AutoSize = true;
			this.domainLabel.Dock = System.Windows.Forms.DockStyle.Right;
			this.domainLabel.Location = new System.Drawing.Point(278, 0);
			this.domainLabel.Name = "domainLabel";
			this.domainLabel.Padding = new System.Windows.Forms.Padding(0, 4, 0, 3);
			this.domainLabel.Size = new System.Drawing.Size(18, 20);
			this.domainLabel.TabIndex = 14;
			this.domainLabel.Text = "@";
			this.domainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// LoginForm
			// 
			this.AcceptButton = this.loginButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(384, 152);
			this.Controls.Add(this.usernamePanel);
			this.Controls.Add(this.savePasswordCheckBox);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.passwordLabel);
			this.Controls.Add(this.loginButton);
			this.Controls.Add(this.usernameLabel);
			this.Controls.Add(this.passwordTextBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.MinimumSize = new System.Drawing.Size(400, 186);
			this.Name = "LoginForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login to Google";
			this.usernamePanel.ResumeLayout(false);
			this.usernamePanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox usernameTextBox;
		private System.Windows.Forms.Label passwordLabel;
		private System.Windows.Forms.Label usernameLabel;
		private System.Windows.Forms.TextBox passwordTextBox;
		private System.Windows.Forms.Button loginButton;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.CheckBox savePasswordCheckBox;
		private System.Windows.Forms.Panel usernamePanel;
		private System.Windows.Forms.Label domainLabel;

	}
}