using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Windows.Forms;

namespace GoogleAppsClient
{
	public partial class LoginForm : Form
	{
		public const string DefaultDomain = "@gmail.com";

		bool hasInitialPassword = false;

		public LoginForm()
		{
			InitializeComponent();

			domainLabel.Text = DefaultDomain;
		}

		#region Event Handlers

		void usernameTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (domainLabel.Visible == usernameTextBox.Text.Contains("@"))
				domainLabel.Visible = !usernameTextBox.Text.Contains("@");
		}

		void passwordTextBox_TextChanged(object sender, System.EventArgs e)
		{
			hasInitialPassword = false;
		}

		void passwordTextBox_Enter(object sender, System.EventArgs e)
		{
			passwordTextBox.SelectAll();
		}

		#endregion

		#region Public Properties

		public string Domain
		{
			get { return domainLabel.Text.Substring(1); }
		}

		public string Username
		{
			get
			{
				var username = RawUsername;
				return !username.Contains("@")
					? username + domainLabel.Text
					: username;
			}
			set
			{
				var index = value.IndexOf("@");
				if (index != -1)
				{
					usernameTextBox.Text = value.Substring(0, index);
					domainLabel.Text = "@" + value.Substring(index + 1);
					return;
				}

				usernameTextBox.Text = value;
				domainLabel.Text = "@" + DefaultDomain;
			}
		}

		public string RawUsername
		{
			get { return usernameTextBox.Text.Trim(); }
			set { usernameTextBox.Text = value; }
		}

		public bool HasInitialPassword
		{
			get { return hasInitialPassword; }
			set
			{
				passwordTextBox.Text = !value
					? ""
					: "password";
				hasInitialPassword = value;
			}
		}

		public SecureString Password
		{
			get
			{
				return !hasInitialPassword
					? Security.ToSecureString(passwordTextBox.Text)
					: null;
			}
		}

		public bool SavePassword
		{
			get { return savePasswordCheckBox.Checked; }
			set { savePasswordCheckBox.Checked = value; }
		}

		#endregion
	}
}
