using System;

namespace SimpleCalculator
{
    public class InputConverter
    {
        public double ConvertInputToNumeric(string argTextInput)
        { double numDouble;
            
            bool attemptParse = double.TryParse(argTextInput, out numDouble);

            if (!attemptParse) { }
            return 0;
            }
             
            
        }
    }
}
