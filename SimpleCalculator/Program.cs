using System;
using CalcLibrary;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var a = 5.5m;
                var b = 2.2m;
                var c = CalcUtilities.add(a, b);
              
                // Class to perform actual calculations
                CalculatorEngine calculatorEngine = new CalculatorEngine();

                Console.WriteLine("enter the first number in its numerical form:");
                double firstNumber = InputConverter.ConvertInputToNumeric(Console.ReadLine());
                Console.WriteLine("enter the second number in its numerical form:");
                double secondNumber =InputConverter.ConvertInputToNumeric(Console.ReadLine());
                Console.WriteLine("enter the operation you wish to perform: (ex: +, - , x, /) : ");
                string operation = Console.ReadLine();

                double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);
                
                Console.WriteLine("The value {0} {1} the value {2} is equal to {3:.00}",firstNumber,operation ,secondNumber,result.ToString());
                Console.ReadLine();
            } catch (Exception ex)
            {
                // Normally, we'd log this error to a file.
                Console.WriteLine(ex.Message);
            }

        }
    }
}
