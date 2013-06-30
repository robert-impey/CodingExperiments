using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SentenceListing
{
    public partial class MainForm : Form
    {
        private SqlConnection conn;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection();
            conn.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=SentenceListing;Integrated Security=True";

            conn.Open();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
        }
    }
}
