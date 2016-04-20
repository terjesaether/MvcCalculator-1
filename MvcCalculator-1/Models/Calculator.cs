using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcCalculator_1.Models
{
    public class Calculator
    {
        public double Operations(string op, double i1, double i2, out string m, out string operatorText)
        {
            double result = 0;
            string message = ""; // Message is for error messages
            string opText = "";
            
            switch (op)
            {
                case "Additon":
                    result = Add(i1, i2);
                    message = "";
                    opText = "plus";
                    break;
                case "Subtraction":
                    result = Subtract(i1, i2);
                    message = "";
                    opText = "minus";
                    break;
                case "Multiplication":
                    result = Multiply(i1, i2);
                    message = "";
                    opText = "times";
                    break;
                case "Division":
                    result = Divide(i1, i2, out message);
                    opText = "divided by";                    
                    break;
                case "Square":
                    result = Square(i1);
                    opText = "squared";
                    break;
                case "Sin":
                    result = Sin(i1);
                    opText = "sinus";
                    break;
            }
            
            m = message;
            operatorText = opText;
            return result;
        }

        private double Sin(double i1)
        {
            return Math.Sin(i1);
        }

        private double Square(double i1)
        {
            return Math.Sqrt(i1);
        }

        public double Add(double i1, double i2)
        {
            return i1 + i2;
        }

        public double Subtract(double i1, double i2)
        {
            return i1 - i2;
        }

        public double Multiply(double i1, double i2)
        {
            return i1 * i2;
        }

        public double Divide(double i1, double i2, out string message)
        {           
            if (i2 != 0)
            {
                message = "";
                return i1 / i2;              
            }
            else
            {
                message = "Computer says: you cannot divide by zero!";
                return 0;               
            }
        }
        
    }

   

    
}