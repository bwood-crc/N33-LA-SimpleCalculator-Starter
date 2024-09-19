using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                //String operator1 = "+";

                //Console.WriteLine(firstNumber + operator1);



                //// Class to convert user input
                //InputConverter inputConverter = new InputConverter();

                //// Class to perform actual calculations
                //CalculatorEngine calculatorEngine = new CalculatorEngine();



                //    double firstNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                //while (!(firstNumber.Equals(double)))
                //{
                //    firstNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                //}
                //double secondNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                //string operation = Console.ReadLine();

                //double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);


                double firstNumber = 10;
                double secondNumber = 20;
                string operator1 = "+";
                double result = firstNumber + secondNumber;

                StringBuilder stringBuilder = new StringBuilder($"{firstNumber} {operator1} {secondNumber} is equal to: {result}");

                Console.WriteLine(stringBuilder.ToString());

               
            } catch (Exception ex)
            {
                // Normally, we'd log this error to a file.
                Console.WriteLine(ex.Message);


                
            }

          

        }
    }
}
