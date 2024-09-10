using System;

namespace SimpleCalculator
{
    public class InputConverter
    {
        public static bool ConvertInputToNumeric(string argTextInput, out double ConvertedResult)
        {
            bool isTrue = true;
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
                Console.WriteLine(ex.Message);
                
            }

            return isTrue;

        }
      
        }
    }

