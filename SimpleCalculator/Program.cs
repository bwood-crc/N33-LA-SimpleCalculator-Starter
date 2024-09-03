using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Class to convert user input
                InputConverter inputConverter = new InputConverter();

                // Class to perform actual calculations
                CalculatorEngine calculatorEngine = new CalculatorEngine();

                //double firstNumber = InputConverter.ConvertInputToNumeric(Console.ReadLine());
                double firstNumber;
                string firstInput;
                Console.WriteLine("Enter the first number of the opperation: ");
                firstInput = Console.ReadLine();
                do
                {
                    Console.WriteLine("Invalid Entry, enter a numerical: ");
                    firstInput = Console.ReadLine();
                }while(!double.TryParse(firstInput, out firstNumber));
                //double secondNumber = InputConverter.ConvertInputToNumeric(Console.ReadLine());
                string operation = Console.ReadLine();

                double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);

                Console.WriteLine("The awnser is {0:.##}",result);

            } catch (Exception ex)
            {
                // Normally, we'd log this error to a file.
                Console.WriteLine(ex.Message);
            }

        }
    }
}
