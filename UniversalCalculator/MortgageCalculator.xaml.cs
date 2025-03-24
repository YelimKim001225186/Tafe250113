using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Calculator
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class MortgageCalculator : Page
	{
		public MortgageCalculator()
		{
			this.InitializeComponent();
		}



		private void Button_Click(object sender, RoutedEventArgs e)
		{
			double principal = double.Parse(principalTextBox.Text);
			int years = int.Parse(yearsTextBox.Text);
			int months = int.Parse(monthsTextBox.Text);
			double yearlyIR = double.Parse(yearlyIRTextBox.Text);
			double monthlyIR = yearlyIR / 100 / 12;
			int totalPayment = years * 12;
			double repayment= (principal * monthlyIR) /
								   (1 - Math.Pow(1 + monthlyIR, -totalPayment));

			monthlyIRTextBox.Text = Convert.ToString(monthlyIR);
			repaymentTextBox.Text = Convert.ToString(repayment);


			//double principal;
			//int years;
			//int months;
			//double yearlyInterestRate;
			//try
			//{
			//	principal = double.Parse(principalTextBox.Text);
			//	years = int.Parse(yearsTextBox.Text);
			//	months = int.Parse(monthlyIRTextBox);
			//	yearlyInterestRate = double.Parse(yearlyIRTextBox);
			//}
			//catch (FormatException)
			//{

			//}

			//double monthlyInterestRate = yearlyInterestRate / 100 / 12;


			//int totalPayments = (years * 12) + months;

			//// Calculate monthly repayment using the loan amortization formula
			//double monthlyRepayment = (principal * monthlyInterestRate) /
			//						   (1 - Math.Pow(1 + monthlyInterestRate, -totalPayments));



			//private int totalMonths = (years * 12) + months;
			//private double monthlyInterestRate = yearInterestRate / 12 / 100;


			//private double monthlyRepayment = (principal * monthlyInterestRate * Math.Pow(1 + monthlyInterestRate, totalMonths)) /
			//					  (Math.Pow(1 + monthlyInterestRate, totalMonths) - 1);


		}

	
	}
}

