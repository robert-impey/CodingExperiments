using System;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;

namespace AsyncForms
{
    public partial class UrlFetcher : Form
    {
        public UrlFetcher()
        {
            InitializeComponent();
        }

        private void FetchButton_Click(object sender, EventArgs e)
        {
            statusTextBox.Text = "Fetching...";

            using (var httpClient = new WebClient())
            {
                urlContentTextBox.Text = httpClient.DownloadString(urlTextBox.Text);
            }

            statusTextBox.Text = string.Empty;
        }

        private async void FetchAsyncButton_Click(object sender, EventArgs e)
        {
            UIState = false;

            statusTextBox.Text = "Fetching...";

            using (var httpClient = new HttpClient())
            {
                urlContentTextBox.Text = await httpClient.GetStringAsync(urlTextBox.Text);
            }

            statusTextBox.Text = string.Empty;
            UIState = true;
        }

        private bool UIState
        {
            set 
            {
                fetchButton.Enabled = value;
                fetchAsyncButton.Enabled = value;
                urlTextBox.ReadOnly = !value;
            }
        }
    }
}
