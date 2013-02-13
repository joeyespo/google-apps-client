using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using System.Xml;

namespace GoogleAppsClient
{
	public partial class MainForm : Form
	{
		const string ACCOUNT_SETTINGS_SECTION = "UserSettings";
		const string DEFAULT_DOMAIN = "@snapretail.com";
		const string GMAIL_DOMAIN = "gmail.com";
		const string ABOUT_URL = "https://github.com/joeyespo/google-apps-client";
		const string BASE_MAIL_URL = "https://mail.google.com/";
		const string DOMAIN_SEPARATOR = "a/";
		const string EMAIL_URL = "https://mail.google.com/mail/feed/atom";

		bool exiting = false;
		LoginForm loginForm = null;
		readonly Font iconFont = new Font("Arial", 8f, FontStyle.Bold);
		int? lastMailCount = null;
		IAsyncResult currentRequestResult = null;

		string username = "";
		string encryptedPassword = "";
		bool savePassword = true;

		public MainForm()
		{
			InitializeComponent();
		}

		#region Event Handlers

		void MainForm_Shown(object sender, EventArgs e)
		{
			SetupApp();
		}

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

		void GetMailAsyncCallback(IAsyncResult ar)
		{
			if (InvokeRequired)
			{
				Invoke(new AsyncCallback(GetMailAsyncCallback), ar);
				return;
			}

			EndRefreshAccount((WebRequest)ar.AsyncState);
		}

		void checkTimer_Tick(object sender, EventArgs e)
		{
			RefreshAccount();
		}

		void newEmailCountCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			RefreshAccount();
		}

		void closeButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		void loginButton_Click(object sender, EventArgs e)
		{
			Login();
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

		void SetupApp()
		{
			LoadSettings();
			UpdateAccountSettings();
			if (HasCredentials())
				Hide();
		}

		void Exit()
		{
			exiting = true;
			Close();
		}

		void ShowAbout()
		{
			Process.Start(ABOUT_URL);
		}

		void LoadSettings()
		{
			var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal);
			var settings = config.Sections[ACCOUNT_SETTINGS_SECTION] as UserSettings;
			if (settings == null)
				return;

			username = settings.Username;
			encryptedPassword = settings.EncryptedPassword;
			savePassword = settings.SavePassword;
		}

		void SaveSettings()
		{
			var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal);
			var settings = config.Sections[ACCOUNT_SETTINGS_SECTION] as UserSettings;
			var addSettings = settings == null;
			if (addSettings)
				settings = new UserSettings();

			settings.Username = username;
			settings.EncryptedPassword = savePassword
				? encryptedPassword
				: "";
			settings.SavePassword = savePassword;

			if (addSettings)
			{
				settings.SectionInformation.AllowExeDefinition = ConfigurationAllowExeDefinition.MachineToLocalUser;
				config.Sections.Add(ACCOUNT_SETTINGS_SECTION, settings);
			}
			config.Save();
		}

		bool Login()
		{
			Show();

			if (loginForm != null)
			{
				loginForm.Show();
				loginForm.Activate();
				return false;
			}

			try
			{
				using (loginForm = new LoginForm())
				{
					loginForm.Username = !string.IsNullOrWhiteSpace(username) ? username : DEFAULT_DOMAIN;
					loginForm.HasInitialPassword = !string.IsNullOrEmpty(encryptedPassword);
					loginForm.SavePassword = savePassword;

					if (loginForm.ShowDialog(this) != DialogResult.OK)
						return false;

					username = loginForm.Username;
					if (!loginForm.HasInitialPassword && loginForm.Password != null)
						encryptedPassword = Security.EncryptString(loginForm.Password);
					savePassword = loginForm.SavePassword;
				}
			}
			finally
			{
				loginForm = null;
			}

			SaveSettings();
			UpdateAccountSettings();
			return true;
		}

		void OpenGmail()
		{
			if (!HasCredentials())
			{
				if (!Login())
					return;
			}

			var url = BASE_MAIL_URL;
			var index = username != null ? username.IndexOf("@") : -1;
			if (index != -1 && username.Substring(index + 1) != GMAIL_DOMAIN)
				url += DOMAIN_SEPARATOR + username.Substring(index + 1);

			Process.Start(url);
		}

		bool HasCredentials()
		{
			return !string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(encryptedPassword);
		}

		void UpdateAccountSettings()
		{
			checkTimer.Enabled = HasCredentials();

			statusLabel.ForeColor = Color.FromKnownColor(KnownColor.ControlText);
			statusLabel.Text = "Logging in...";
			loginButton.Visible = false;
			logoutButton.Visible = false;

			if (RefreshAccount())
				Cursor = Cursors.WaitCursor;
		}

		bool RefreshAccount()
		{
			if (!HasCredentials())
			{
				statusLabel.Text = "Offline";
				logoutButton.Visible = false;
				loginButton.Visible = true;
				SetOffline();
				return false;
			}

			BeginGetMailCount();
			return true;
		}

		void EndRefreshAccount(WebRequest request)
		{
			Cursor = Cursors.Default;

			int mailCount;
			try
			{
				mailCount = EndGetMailCount(request);
			}
			catch (WebException ex)
			{
				statusLabel.Text = ex.Message;
				statusLabel.ForeColor = Color.Red;
				loginButton.Visible = true;
				logoutButton.Visible = false;
				SetOffline();
				return;
			}

			statusLabel.Text = "Logged in as " + username;
			loginButton.Visible = false;
			logoutButton.Visible = true;

			var image = mailCount > 0
				? (newEmailCountCheckBox.Checked
					? RenderNewMailIcon(mailCount)
					: iconImageList.Images[2])
				: iconImageList.Images[1];

			SetNotifyImage(image);
			notifyIcon.Text = string.Format("{0} unread conversation{1}", mailCount, mailCount != 1 ? "s" : "");
			lastMailCount = mailCount;
		}

		void ShowSettings()
		{
			Show();
		}

		#endregion

		#region Helpers

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
				var radius = (float)Math.Floor(g.MeasureString(s, iconFont).Width / 2d);
				g.DrawImageUnscaled(iconImageList.Images[3], 0, 0, 16, 16);
				g.DrawString(s, iconFont, Brushes.White, 9f - radius, 3f);
				return bitmap;
			}
		}

		void SetOffline()
		{
			if (lastMailCount != null || notifyIcon.Icon == null)
				SetNotifyImage(iconImageList.Images[0]);
			notifyIcon.Text = "Offline - Google Apps Client";
			lastMailCount = null;
		}

		void SetNotifyImage(Image image)
		{
			if (notifyIcon.Icon != null)
				notifyIcon.Icon.Dispose();
			notifyIcon.Icon = ImageToIcon(image);
		}

		void BeginGetMailCount()
		{
			if (currentRequestResult != null)
				return;

			var request = WebRequest.Create(EMAIL_URL);
			request.PreAuthenticate = true;
			request.Credentials = new NetworkCredential(username, Security.ToInsecureString(encryptedPassword));
			currentRequestResult = request.BeginGetResponse(GetMailAsyncCallback, request);
		}

		int EndGetMailCount(WebRequest request)
		{
			var requestResult = currentRequestResult;
			currentRequestResult = null;

			var response = request.EndGetResponse(requestResult);
			using (var unreadStream = response.GetResponseStream()) {
				var unreadMailXmlDoc = new XmlDocument();
				unreadMailXmlDoc.Load(unreadStream);

				var unreadMailEntries = unreadMailXmlDoc.GetElementsByTagName("entry");
				return unreadMailEntries.Count;
			}
		}

		#endregion

		private void logoutButton_Click(object sender, EventArgs e)
		{

		}
	}
}
