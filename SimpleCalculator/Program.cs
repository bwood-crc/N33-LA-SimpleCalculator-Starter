﻿using System;
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

               // Class to convert user input
                InputConverter inputConverter = new InputConverter();

                // Class to perform actual calculations
                CalculatorEngine calculatorEngine = new CalculatorEngine();

                double firstNumber, secondNumber;
                
                Console.Write("Enter the first number: ");
                String temp = Console.ReadLine();
                while (!double.TryParse(temp, out firstNumber))
                {
                    Console.Write("Invalid input!!! Enter the first number: ");
                    temp = Console.ReadLine();
                }
                firstNumber = InputConverter.ConvertInputToNumeric(temp);
                Console.Write("Enter the second number: ");
                String temp2 = Console.ReadLine();

                while (!double.TryParse(temp2, out secondNumber))
                {
                    Console.Write("Invalid input!!! Enter the second number: ");
                    temp2 = Console.ReadLine();
                }
                secondNumber = InputConverter.ConvertInputToNumeric(temp2);

                Console.Write("Enter the operator (+, -, *, /): ");
                string operation = Console.ReadLine();


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
