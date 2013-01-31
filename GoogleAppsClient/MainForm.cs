using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GoogleAppsClient
{
	public partial class MainForm : Form
	{
		const string BASE_URL = "https://mail.google.com/";
		const string DOMAIN_SEPARATOR = "a/";

		bool exiting = false;

		public MainForm()
		{
			InitializeComponent();
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

		void fileExitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Exit();
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

		#endregion
	}
}
