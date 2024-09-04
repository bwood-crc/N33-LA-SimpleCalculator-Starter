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
        static bool attValidate = false;
        public static string[] operationOptions = { "add", "+", "minus", "-", "multiply", "*", "divide", "/", "percent", "%" };

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
        public static bool operationValidator(string operation)
        {
            operation = operation.ToLower().Trim();
            

            foreach (string i in operationOptions)
            {
                if (operation.Equals(i))
                {
                    attValidate = true;
                }
            }
            return attValidate;
        }
        
    }
}
