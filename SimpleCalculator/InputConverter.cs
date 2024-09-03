using System;

namespace SimpleCalculator
{
    public class InputConverter
    {
        static double result = 0;
       static bool attParse = false;

        public static bool ValidInput(string input)
        {
            bool attParse = double.TryParse(input, out result);
            return attParse;

        }
        public static double ConvertInputToNumeric(string argTextInput)
        {
            result = double.Parse(argTextInput);
            return result;
        }

    }
}
