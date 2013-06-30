using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProgrammingNamingConventionsLib;

namespace ProgrammingNamingConventions
{
    public partial class ProgrammingNamingConventions : Form
    {
        public ProgrammingNamingConventions()
        {
            InitializeComponent();
        }

        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {
            string input = inputTextBox.Text;
            camelCaseOutputLabel.Text = Translator.ToCamelCase(input);
        }
    }
}
