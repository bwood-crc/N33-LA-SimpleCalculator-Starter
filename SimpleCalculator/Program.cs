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

                while(!Converter.ValidInput(firstInput)) 
                {
                    Console.WriteLine("Invalid Entry, enter a numerical: ");
                    firstInput = Console.ReadLine();
                }
                //test
                //Console.WriteLine(firstInput);
                //testworks
                //double secondNumber = InputConverter.ConvertInputToNumeric(Console.ReadLine());
                string operation = Console.ReadLine();

                //double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);

               // Console.WriteLine("The awnser is {0:.##}",result);

            } catch (Exception ex)
            {
                // Normally, we'd log this error to a file.
                Console.WriteLine(ex.Message);
            }

        }
    }
}
