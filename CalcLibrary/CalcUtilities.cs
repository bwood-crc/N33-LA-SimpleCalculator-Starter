

namespace CalcLibrary
    
{
    public class CalcUtilities
    {
        public static double Calculate(string argOperation, double argFirstNumber, double argSecondNumber)

        {
            double result = 0;

            switch (argOperation.ToLower())
            {
                case "+":
                case "add":



                    result = argFirstNumber + argSecondNumber;

                    return result; ;

                    break;

                case "-":
                case "substract":

                    result = argFirstNumber - argSecondNumber;

                    return result;

                    break;

                case "*":
                case "multiply":

                    result = argFirstNumber * argSecondNumber;

                    return result;

                    break;

                case "/":
                case "division":

                    result = argFirstNumber / argSecondNumber;
                    return result;


                    break;


            }

            return result;


        }
    }
}
