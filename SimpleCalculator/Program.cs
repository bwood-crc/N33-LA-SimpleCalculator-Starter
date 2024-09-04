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
                var c = CalcUtilities.Calculate.add(a, b);
              
                // Class to perform actual calculations
                CalculatorEngine calculatorEngine = new CalculatorEngine();

                double firstNumber = InputConverter.ConvertInputToNumeric(Console.ReadLine());
                double secondNumber =InputConverter.ConvertInputToNumeric(Console.ReadLine());
                string operation = Console.ReadLine();

                double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);

                Console.WriteLine("The answer is : " + result.ToString());

            } catch (Exception ex)
            {
                // Normally, we'd log this error to a file.
                Console.WriteLine(ex.Message);
            }

        }
    }
}
