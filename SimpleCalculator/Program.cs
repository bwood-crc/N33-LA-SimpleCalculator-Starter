using System;
using System.Text;
using CalculatorEngine;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Class to convert user input
                //InputConverter inputConverter = new InputConverter(); no need for instance cuz static wow

                // Class to perform actual calculations
                //  CalculatorEngine calculatorEngine = new CalculatorEngine();

                Console.WriteLine("input first number: ");
                double firstNumber = InputConverter.ConvertInputToNumeric(Console.ReadLine());

                Console.WriteLine("input your second number: ");
                double secondNumber = InputConverter.ConvertInputToNumeric(Console.ReadLine());

                Console.WriteLine("Enter the operation (+, -, *, /): ");
                string operation = Console.ReadLine();

                var calculatorEngine = new CalculatorEngine();

                double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);


                // Console.WriteLine(result);

                var sb = new StringBuilder();
                sb.AppendFormat("The value {0} {1} {2} is equal to {3:F2}", firstNumber, operation, secondNumber, result);
                Console.WriteLine(sb.ToString());

            }
            catch (Exception ex)
            {
                // Normally, we'd log this error to a file.
                Console.WriteLine(ex.Message);
            }

        }
    }
}