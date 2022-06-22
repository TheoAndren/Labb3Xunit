using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3Xunit
{
    public class Calculator
    {
        public static decimal UserInput(string num)
        {
            try
            {
                decimal.Parse(num);
            }
            catch (Exception)
            {
                throw new ArgumentException("Pick a number.");
            }

            return decimal.Parse(num);
        }

        public static decimal Addition(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        public static decimal Subtraction(decimal num1, decimal num2)
        {
            return num1 - num2;
        }

        public static decimal Division(decimal num1, decimal num2)
        {
            if (num2 == 0)
            {
                throw new ArgumentException(" Cant divide a number with 0.");
            }

            decimal result = Math.Round(num1 / num2, 5);
            return result;
        }

        public static decimal Multiplication(decimal num1, decimal num2)
        {
            return num1 * num2;
        }

        public static string PrintResult(decimal num1, decimal num2, decimal result, string calcType)
        {
            Console.Write($"\n  {num1} {calcType} {num2} = {result}");
            string calculation = num1.ToString() + " " + calcType + " " + num2.ToString() + " = " + result.ToString();
            return calculation;
        }

        public static int PrintAllCalculations(List<string> calculations)
        {
            int numberOfCalculations = 0;
            foreach (var calculation in calculations)
            {
                Console.WriteLine("  " + calculation);
                numberOfCalculations++;
            }

            return numberOfCalculations;
        }
    }
}