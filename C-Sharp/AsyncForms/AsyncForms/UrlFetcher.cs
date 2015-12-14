using System;
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

        private async void goFetchButton_Click(object sender, EventArgs e)
        {
            urlContentTextBox.Text = "Fetching...";

            using (var httpClient = new HttpClient())
            {
                urlContentTextBox.Text = await httpClient.GetStringAsync(urlTextBox.Text);
            }
        }
    }
}
