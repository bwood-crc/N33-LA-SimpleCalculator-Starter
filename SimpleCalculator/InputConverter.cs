using System;

namespace SimpleCalculator
{
    public class InputConverter
    {
        public static double ConvertInputToNumeric(string argTextInput)
        {
            double input = 0;
            int tester = 1;
            do
            {
                try
                {
                    input = Convert.ToDouble(argTextInput);
                    tester = 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Enter the number's numerical value!");
                    tester = 1;
                }
                Console.WriteLine("Enter ");
            }while (tester != 0);
            return input;
        }
    }
}
