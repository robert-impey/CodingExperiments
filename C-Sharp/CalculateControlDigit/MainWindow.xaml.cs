using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CalculateControlDigit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            var controlDigitTuple = ControlDigitCalculator.ParseAndCalculate(inputTextBox.Text);

            if (controlDigitTuple.Item1.HasValue)
            {
                errorLabel.Content = "";
                controlDigitTextBox.Text = controlDigitTuple.Item1.Value.ToString();
            }
            else
            {
                errorLabel.Content = controlDigitTuple.Item2;
            }
        }
    }
}
