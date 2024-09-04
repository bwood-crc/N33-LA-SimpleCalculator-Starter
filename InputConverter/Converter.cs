using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputConverter
{
    public class Converter
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
