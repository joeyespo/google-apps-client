using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace GoogleAppsClient
{
	public partial class MainForm : Form
	{
		const string ABOUT_URL = "https://github.com/joeyespo/google-apps-client";
		const string BASE_URL = "https://mail.google.com/";
		const string DOMAIN_SEPARATOR = "a/";

		bool exiting = false;
		readonly Font iconFont = new Font("Arial", 7f, FontStyle.Bold);

		public MainForm()
		{
			InitializeComponent();

			notifyIcon.Icon = (Icon)notifyIcon.Icon.Clone();
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

		void aboutGoogleAppsClientToolStripMenuItem_Click(object sender, EventArgs e)
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

		void OpenGmail()
		{
			var url = BASE_URL;
			if (!string.IsNullOrWhiteSpace(domainTextBox.Text))
				url += DOMAIN_SEPARATOR + domainTextBox.Text;

			Process.Start(url);
		}

		void ShowSettings()
		{
			Show();
		}

		void ShowAbout()
		{
			Process.Start(ABOUT_URL);
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

		void SetNewMailIcon(int count)
		{
			notifyIcon.Icon.Dispose();
			notifyIcon.Icon = RenderNewMailIcon(count);
		}

		Icon RenderNewMailIcon(int count)
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
				return ImageToIcon(bitmap);
			}
		}

		#endregion
	}
}
