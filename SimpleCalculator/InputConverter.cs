using System;

namespace SimpleCalculator
{
    public class InputConverter
    {
        public static double ConvertInputToNumeric(string argTextInput)
        {
            switch (argTextInput)
            {
                case "0":
                    return 0.0;
               case "1":
                   return 1.0;
               case "2":
                   return 2.0;
               case "3":
                   return 3.0;
               case "4":
                   return 4.0;
               case "5":
                   return 5.0;
               case "6":
                   return 6.0;
               case "7":
                   return 7.0;
               case "8":
                   return 8.0;
               case "9":
                   return 9.0;
               default:
                   Console.WriteLine("Invalid input");
                   return 0.0;
            }
    }
}
