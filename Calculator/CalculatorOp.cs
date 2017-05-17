using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalculatorOp
    {
        // + Addition
        public double Add(double num1, double num2)
        {
            double result = num1 + num2;
            return result;
        }
        // - Substraction
        public double Substract(double num1, double num2)
        {
            double result = num1 - num2;
            return result;
        }

        // * Multiply
        public double Mult(double num1, double num2)
        {
            double result = num1 * num2;
            return result;
        }
        // / Division
        public double Division(double num1, double num2)
        {
            double result = num1 / num2;
            return result;
        }
    }
}
