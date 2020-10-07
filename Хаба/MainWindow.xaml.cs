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

namespace Хаба
{
	
	public partial class MainWindow : Window
	{
		Model model;

		public MainWindow()
		{
			InitializeComponent();
			model = new Model();
		}

		private void CalculateButton_Click(object sender, RoutedEventArgs e) // Получение значений
		{
			string text1 = Num1TextBox.Text.Trim();
			string text2 = Num2TextBox.Text.Trim();
			double num1 = 0;
			double num2 = 0;
			if (!string.IsNullOrEmpty(text1) && !string.IsNullOrEmpty(text2))
			{
				try
				{
					num1 = Convert.ToInt32(text1);
					num2 = Convert.ToInt32(text2);
				}
				catch (Exception exc) { }
				Calculate(num1, num2);

				ResultTextBlock.Text = model.result.ToString(); // Обновить viev
			}
		}

		public void Calculate(double num1, double num2) // Отправка знаений в модель
		{
			switch (OperatorType.Text)
			{
				case "+":
					model.Add(num1, num2);
					break;
				case "-":
					model.Subtraction(num1, num2);
					break;
				case "*":
					model.Multiplication(num1, num2);
					break;
				case "/":
					model.Division(num1, num2);
					break;
				case "%":
					model.percent(num1, num2);
					break;
				case "^":
					model.Pow(num1, num2);
					break;
				case "log":
					model.Log10(num1);
					break;
				case "Sqrt":
					model.Sqrt(num1);
					break;

			}
		}
	}
}
