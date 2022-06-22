using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3Xunit
{
    public class Menu
    {
        public static void MenuOptions()
        {
            List<string> calculations = new List<string>();
            string calcType;
            decimal num1 = 0;
            decimal num2 = 0;

            bool run = true;
            while (run)
            {
                Console.WriteLine("  \tCALCULATOR App\n\n" +
                "  [1] Addition\n" +
                "  [2] Subtraction\n" +
                "  [3] Divison\n" +
                "  [4] Multiplication\n" +
                "  [5] Stored Calculations\n");
                Console.Write("  Choose: ");
                int selected = 0;
                bool validSelection = false;
                while (!validSelection || selected < 1 || selected > 5)
                {
                    try
                    {
                        selected = Int32.Parse(Console.ReadLine());
                        validSelection = true;
                    }
                    catch (Exception)
                    {
                        Console.Write(" Enter a number between 1-5: ");
                        validSelection = false;
                    }
                    if ((selected < 1 || selected > 5) && validSelection == true)
                    {
                        Console.Write(" Enter a number between 1-5: ");
                    }
                }

                switch (selected)
                {
                    case 1: // Addition
                        Console.Clear();
                        Console.WriteLine("\tAddition\n");
                        calcType = "+";

                        // User input
                        Console.Write("Enter first number: ");
                        num1 = Calculator.UserInput(Console.ReadLine());

                        Console.Write(" Enter second number: ");
                        num2 = Calculator.UserInput(Console.ReadLine());

                        calculations.Add(Calculator.PrintResult(num1, num2, Calculator.Addition(num1, num2), calcType));
                        break;
                    case 2: // Subtraction
                        Console.Clear();
                        Console.WriteLine("\tSubtraction\n");
                        calcType = "-";

                        // User input
                        Console.Write(" Enter first number: ");
                        num1 = Calculator.UserInput(Console.ReadLine());

                        Console.Write("Enter second number: ");
                        num2 = Calculator.UserInput(Console.ReadLine());

                        calculations.Add(Calculator.PrintResult(num1, num2, Calculator.Subtraction(num1, num2), calcType));
                        break;
                    case 3: // Division
                        Console.Clear();
                        Console.WriteLine("\tDivision\n");
                        calcType = "/";

                        // User input
                        Console.Write("Enter first number: ");
                        num1 = Calculator.UserInput(Console.ReadLine());

                        Console.Write("Enter second number: ");
                        num2 = Calculator.UserInput(Console.ReadLine());

                        calculations.Add(Calculator.PrintResult(num1, num2, Calculator.Division(num1, num2), calcType));
                        break;
                    case 4:  // Multiplication
                        Console.Clear();
                        Console.WriteLine("\tMultiplication\n");
                        calcType = "*";

                        // User input
                        Console.Write("Enter first number: ");
                        num1 = Calculator.UserInput(Console.ReadLine());

                        Console.Write("Enter second number: ");
                        num2 = Calculator.UserInput(Console.ReadLine());

                        calculations.Add(Calculator.PrintResult(num1, num2, Calculator.Multiplication(num1, num2), calcType));
                        break;

                    case 5: // Print all calculations
                        Console.Clear();
                        Console.WriteLine("\tStored Calculations\n");

                        Calculator.PrintAllCalculations(calculations);
                        break;
                    default:
                        break;
                }

                // Return to menu
                Console.WriteLine("\n\n Press any button to return to menu");
                Console.ReadKey();
                Console.Clear();
            }

        }
    }
}