using System;

namespace Хаба
{
	class Model
	{
		public double result { get; set; }

		public void Add(double num1, double num2)
		{
			result = num1 + num2;
		}

		public void Subtraction(double num1, double num2)
		{
			result = num1 - num2;
		}

		public void Multiplication(double num1, double num2)
		{
			result = num1 * num2;
		}

		public void Division(double num1, double num2)
		{
			result = num1 / num2;
		}

		public void percent(double num1, double num2)
		{
			result = num1 / 100 * num2;
		}

		public void Pow(double num1, double num2)
		{
			result = Math.Pow(num1, num2);
		}

        internal void Log10(double num1)
        {
			result = Math.Log10(num1);
        }

		internal void Sqrt(double num1)
		{
			result = Math.Sqrt(num1);
		}


	}
}