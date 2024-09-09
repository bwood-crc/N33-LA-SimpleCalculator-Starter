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


                // Class to perform actual calculations

                Console.WriteLine("enter the first number in its numerical form:");
                double firstNumber = InputConverter.ConvertInputToNumeric(Console.ReadLine());
                Console.WriteLine("enter the second number in its numerical form:");
                double secondNumber = InputConverter.ConvertInputToNumeric(Console.ReadLine());
                Console.WriteLine("enter the operation you wish to perform: (ex: + or plus, - or substract , x or multiply, / or divide, ^ or power) : ");
                string operation = InputConverter.OperationConverter(Console.ReadLine());

                double result = CalcUtilities.Calculate(operation, firstNumber, secondNumber);

                if (firstNumber == 0 && operation == "division" || firstNumber == 0 && operation == "/" || secondNumber == 0 && operation == "division" || secondNumber == 0 && operation == "/")
                {
                    result = 0;
                }

                
                Console.WriteLine("The value {0} {1} the value {2} is equal to {3:0.00}",firstNumber,operation ,secondNumber,result);
                Console.ReadLine();
            } catch (Exception ex)
            {
                // Normally, we'd log this error to a file.
                Console.WriteLine("an error occured in the program");
            }

        }
    }
}
