using System;
using System.Windows.Forms;
using System.Net;

namespace HttpRequests
{
    public partial class HttpRequestsForm : Form
    {
        public HttpRequestsForm()
        {
            InitializeComponent();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            var address = addressTextBox.Text;

            var webRequest = WebRequest.Create(address);

            var response = webRequest.GetResponse();

            var bindingSource = new BindingSource();

            foreach (var key in response.Headers.AllKeys)
            {
                bindingSource.Add(new HeaderValue(key, response.Headers[key]));
            }

            headersDataGridView.DataSource = bindingSource;
            headersDataGridView.AutoSize = true;
        }

        private void HttpRequestsForm_Shown(object sender, EventArgs e)
        {
            addressTextBox.Focus();
        }
    }

    internal class HeaderValue
    {
        public string Header { get; private set; }
        public string Value { get; private set; }

        public HeaderValue(string header, string value)
        {
            Header = header;
            Value = value;
        }
    }
}
