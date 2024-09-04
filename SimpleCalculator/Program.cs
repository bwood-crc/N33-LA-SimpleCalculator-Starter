using System;
using InputConverter;
namespace SimpleCalculator
    
{

    class Program
    {
        static void Main(string[] args)
        {


            try
            {


                double firstNumber;
                string firstInput;
                Console.WriteLine("Enter the first number of the opperation: ");
                firstInput = Console.ReadLine();

                while (!Converter.ValidInput(firstInput))
                {
                    Console.WriteLine("Invalid Entry, enter a numerical: ");
                    firstInput = Console.ReadLine();
                }
                //test
                //Console.WriteLine(firstInput);
                //testworks
                firstNumber = Converter.ConvertInputToNumeric(firstInput);

                double secondNumber;
                string secondInput;
                Console.WriteLine("Enter the second number of the opperation: ");
                secondInput = Console.ReadLine();

                while (!Converter.ValidInput(secondInput))
                {
                    Console.WriteLine("Invalid Entry, enter a numerical: ");
                    secondInput = Console.ReadLine();
                }
                //test
                //Console.WriteLine(secondInput);
                //testworks
                secondNumber = Converter.ConvertInputToNumeric(secondInput);

                //getting operator
                Console.WriteLine("What operation would you like to make ");
                foreach (string i in Converter.operationOptions)
                {
                    Console.Write(i + " , ");
                }
                Console.WriteLine();
                string operationSelection = Console.ReadLine();
                while (!Converter.operationValidator(operationSelection))
                {
                    Console.WriteLine("Input is not valid");
                    foreach (string i in Converter.operationOptions)
                    {
                        Console.Write(i + " , ");
                    }
                    Console.WriteLine();
                    operationSelection = Console.ReadLine();
                }
            }
            catch (Exception ex)
            {
                // Normally, we'd log this error to a file.
                Console.WriteLine(ex.Message);
            }
        }
    }
}
