using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using System.Xml;

namespace GoogleAppsClient
{
	public partial class MainForm : Form
	{
		const string ABOUT_URL = "https://github.com/joeyespo/google-apps-client";
		const string BASE_MAIL_URL = "https://mail.google.com/";
		const string DOMAIN_SEPARATOR = "a/";
		const string EMAIL_URL = "https://mail.google.com/mail/feed/atom";

		bool exiting = false;
		readonly Font iconFont = new Font("Arial", 7f, FontStyle.Bold);
		int? lastMailCount = null;

		public MainForm()
		{
			InitializeComponent();

			SetOffline();
		}

		#region Event Handlers

		protected override void OnClosing(CancelEventArgs e)
		{
			if (!exiting)
			{
				Hide();
				e.Cancel = true;
			}

			base.OnClosing(e);
		}

		protected override bool ProcessDialogKey(Keys keyData)
		{
			if (keyData == Keys.Escape)
				Close();

			return base.ProcessDialogKey(keyData);
		}

		void checkTimer_Tick(object sender, EventArgs e)
		{
			RefreshAccount();
		}

		void usernameTextBox_TextChanged(object sender, EventArgs e)
		{
			if (domainPanel.Visible == usernameTextBox.Text.Contains("@"))
				domainPanel.Visible = !usernameTextBox.Text.Contains("@");
		}

		void usernameTextBox_Leave(object sender, EventArgs e)
		{
			UpdateAccountSettings();
		}

		void passwordTextBox_Leave(object sender, EventArgs e)
		{
			UpdateAccountSettings();
		}

		void closeButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		void fileOpenGmailToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenGmail();
		}

		void fileExitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Exit();
		}

		void helpAboutGoogleAppsClientToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ShowAbout();
		}

		void notifyIcon_DoubleClick(object sender, EventArgs e)
		{
			OpenGmail();
		}

		void openGmailToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenGmail();
		}

		void settingsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ShowSettings();
		}

		void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ShowAbout();
		}

		void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Exit();
		}

		#endregion

		#region Actions

		void Exit()
		{
			exiting = true;
			Close();
		}

		void ShowAbout()
		{
			Process.Start(ABOUT_URL);
		}

		void OpenGmail()
		{
			var url = BASE_MAIL_URL;
			if (!string.IsNullOrWhiteSpace(domainTextBox.Text))
				url += DOMAIN_SEPARATOR + domainTextBox.Text;

			Process.Start(url);
		}

		bool HasCredentials()
		{
			return !string.IsNullOrWhiteSpace(usernameTextBox.Text) && !string.IsNullOrWhiteSpace(passwordTextBox.Text);
		}

		void UpdateAccountSettings()
		{
			// TODO: spinner
			errorProvider.Clear();

			checkTimer.Enabled = HasCredentials();
			RefreshAccount();
		}

		void RefreshAccount()
		{
			if (!HasCredentials())
			{
				SetOffline();
				return;
			}

			int mailCount;
			try
			{
				mailCount = GetMailCount();
			}
			catch(WebException ex)
			{
				errorProvider.SetError(passwordTextBox, ex.Message);
				SetOffline();
				return;
			}

			SetNotifyImage(RenderNewMailIcon(mailCount));
			lastMailCount = mailCount;
		}

		void ShowSettings()
		{
			Show();
		}

		#endregion

		#region Helpers

		string AccountUsername()
		{
			var email = usernameTextBox.Text.Trim();
			return !email.Contains("@")
				? email + "@" + domainTextBox.Text
				: email;
		}

		static Icon ImageToIcon(Image image)
		{
			var bitmap = image as Bitmap;
			if (bitmap == null)
			{
				bitmap = new Bitmap(image.Width, image.Height);
				using (var g = Graphics.FromImage(bitmap))
					g.DrawImageUnscaled(image, 0, 0, image.Width, image.Height);
			}
			var icon = Icon.FromHandle(bitmap.GetHicon());
			bitmap.Dispose();
			return icon;
		}

		Image RenderNewMailIcon(int count)
		{
			var s = count < 100
				? count.ToString()
				: "+";

			var bitmap = new Bitmap(16, 16);
			using (var g = Graphics.FromImage(bitmap))
			{
				var left = 11f;
				var size = g.MeasureString(s, iconFont);
				var radius = (float)Math.Floor(size.Width / 2d);
				var image = iconImageList.Images[2];
				if (left + radius > 16)
				{
					left -= 2;
					image = iconImageList.Images[3];
				}

				g.DrawImageUnscaled(image, 0, 0, 16, 16);
				g.DrawString(s, iconFont, Brushes.White, left - radius, 6f);
				return bitmap;
			}
		}

		void SetOffline()
		{
			if (lastMailCount != null)
				SetNotifyImage(iconImageList.Images[0]);
			lastMailCount = null;
		}

		void SetNotifyImage(Image image)
		{
			if (notifyIcon.Icon != null)
				notifyIcon.Icon.Dispose();
			notifyIcon.Icon = ImageToIcon(image);
		}

		int GetMailCount()
		{
			var request = WebRequest.Create(EMAIL_URL);
			request.PreAuthenticate = true;
			request.Credentials = new NetworkCredential(AccountUsername(), passwordTextBox.Text.Trim());

			using (var response = request.GetResponse())
			using (var unreadStream = response.GetResponseStream()) {
				var unreadMailXmlDoc = new XmlDocument();
				unreadMailXmlDoc.Load(unreadStream);

				var unreadMailEntries = unreadMailXmlDoc.GetElementsByTagName("entry");
				return unreadMailEntries.Count;
			}
		}

		#endregion
	}
}
