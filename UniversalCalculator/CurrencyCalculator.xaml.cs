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

namespace Calculator
{
	/// <summary>
	/// 
	/// </summary>
	public sealed partial class CurrencyCalculator : Page
	{
		public CurrencyCalculator()
		{
			this.InitializeComponent();
		}

		private double GetConversionRate(ComboBox from, ComboBox to)
		{
			if (from.SelectedIndex == 0 && to.SelectedIndex == 1) return 0.85189982; // USD → EUR
			if (from.SelectedIndex == 0 && to.SelectedIndex == 2) return 0.72872436; // USD → GBP
			if (from.SelectedIndex == 0 && to.SelectedIndex == 3) return 74.257327; // USD → INR

			if (from.SelectedIndex == 1 && to.SelectedIndex == 0) return 1.1739732; // EUR → USD
			if (from.SelectedIndex == 1 && to.SelectedIndex == 2) return 0.8556672; // EUR → GBP
			if (from.SelectedIndex == 1 && to.SelectedIndex == 3) return 87.00755; // EUR → INR

			if (from.SelectedIndex == 2 && to.SelectedIndex == 0) return 1.371907; // GBP → USD
			if (from.SelectedIndex == 2 && to.SelectedIndex == 1) return 1.1686692; // GBP → EUR
			if (from.SelectedIndex == 2 && to.SelectedIndex == 3) return 101.68635; // GBP → INR

			if (from.SelectedIndex == 3 && to.SelectedIndex == 0) return 0.011492628; // INR → USD
			if (from.SelectedIndex == 3 && to.SelectedIndex == 1) return 0.013492774; // INR → EUR
			if (from.SelectedIndex == 3 && to.SelectedIndex == 2) return 0.0098339397; // INR → GBP

			return 0;
		}

		private void conversionButton_Click(object sender, RoutedEventArgs e)
		{
			double amount;

			try
			{
				amount = Convert.ToDouble(amountTextBox.Text);
			}
			catch
			{
				conversionRateTextBlock.Text = "Please enter valid number";
				return;
			}

			double conversionRate = GetConversionRate(fromComboBox, toComboBox);

			amountFromTextblock.Text = amount.ToString() + " " + (fromComboBox.SelectedItem as ComboBoxItem)?.Content.ToString() + " = ";
			convertedTextBlock.Text = Convert.ToString(amount * conversionRate) + " " + (toComboBox.SelectedItem as ComboBoxItem)?.Content.ToString();
			conversionRateTextBlock.Text = 1 +" "+ (fromComboBox.SelectedItem as ComboBoxItem)?.Content.ToString() + " = " + Convert.ToString(conversionRate) + " " + (toComboBox.SelectedItem as ComboBoxItem)?.Content.ToString() +
				"\n" + 1 + " " + (toComboBox.SelectedItem as ComboBoxItem)?.Content.ToString() + " = " + Convert.ToString(1/conversionRate) + " " + (fromComboBox.SelectedItem as ComboBoxItem)?.Content.ToString(); ;


		}

		private void exitButton_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(MainMenu));
		}
	}
}
