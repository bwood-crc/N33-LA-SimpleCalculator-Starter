using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CalcTools
{
    public class CalcUti
    {
        static double result = 0;
        static string verb;
        public static string Verbalise(string argOperation, double first, double second, double res)
        {
            switch (argOperation)
            {
                case "add":
                case "+":

                    verb = $"The result of adding {first} to {second} is {res}";
                    break;

                //Minus
                case "minus":
                case "-":

                    verb = $"The result of substracting {second} from {first} is {res}";
                    break;
                //Multiplication
                case "multiply":
                case "*":
                    verb =  $"The result of multiplying {first} by {second} is {res};
                    break;
                //Division
                case "divide":
                case "/":
                    verb =  $"The result of dividing {first} by {second} is {res}";
                    break;
                //Calculating the percentage of the first number
                case "percent":
                case "%":
                    verb =  $"{second} percent of {first} is {res} %";
                    break;
            }
            return verb;
        }
        public static double Calculate(string argOperation, double argFirstNumber, double argSecondNumber) { 
            //There is two cases per switch to be able to take in the symbol and the word
            //Addition
            switch (argOperation) {
                case "add":
                case "+" :


                    result = argFirstNumber + argSecondNumber;
                    break;

                    //Minus
                case "minus":
                case "-":


                    result = argFirstNumber - argSecondNumber;
                    break;
                    //Multiplication
                case "multiply":
                case "*":

                    result = argFirstNumber* argSecondNumber;
                    break;
                    //Division
                case "divide":
                case "/":

                    result = argFirstNumber / argSecondNumber;
                    break;
                    //Calculating the percentage of the first number
                case "percent":
                case "%":

                    result = (argFirstNumber / 100) * argSecondNumber;
                    break;
            }
            //Giving back the awnser
            return result;
        }
        
    }
}
