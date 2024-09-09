using System;

namespace SimpleCalculator
{
    public class InputConverter
    {
        public static bool ConvertInputToNumeric(string argTextInput, out double ConvertedResult)
        {
            bool isTrue = false;
            double input = 0;

            try
            {
                input = Convert.ToDouble(argTextInput);
                ConvertedResult = input;
                isTrue = true;
            }
            catch (Exception ex)
            {
                ConvertedResult = 0;
                isTrue = false;
            }
            return isTrue;

        }
      
        }
    }

