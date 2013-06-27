using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BricksAndMortar
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

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            priceTextBox.Text 
            = depositTextBox.Text 
            = interestTextBox.Text
            = yearsTextBox.Text 
            = loanTextBox.Text
            = monthlyPaymentsTextBox.Text
            = totalCostOfLoanTextBox.Text
            = String.Empty;
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            double interest;
            int years, price, deposit, loan;

            if (
                int.TryParse(priceTextBox.Text, out price)
                && int.TryParse(depositTextBox.Text, out deposit)
                && double.TryParse(interestTextBox.Text, out interest)
                && int.TryParse(yearsTextBox.Text, out years)
            )
            {
                loan = price - deposit;
                loanTextBox.Text = loan.ToString("C2");

                int months = years * 12;
                double monthlyRate = interest / 1200.0;
                double monthlyPayments = (loan * monthlyRate * Math.Pow(1.0 + monthlyRate, months)) / (Math.Pow(1.0 + monthlyRate, months) - 1);

                monthlyPaymentsTextBox.Text = monthlyPayments.ToString("C2");

                double totalCostOfLoan = monthlyPayments * months;
                totalCostOfLoanTextBox.Text = totalCostOfLoan.ToString("C2");
            }
        }
    }
}
