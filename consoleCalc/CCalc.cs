using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;

namespace consoleCalc
{
    class CCalc
    {
        static void Main(string[] args)
        {
            char cont = '+';
            while (cont == '+')
            {
                double num1, num2, result;
                char oper;
                Console.WriteLine("Enter First number");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter operation +-*/");
                oper = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("Enter Second number");
                num2 = Convert.ToDouble(Console.ReadLine());
                CalculatorOp CalculatorOp = new CalculatorOp();
                if (oper == '+')
                {
                   result = CalculatorOp.Add(num1, num2);
                   Console.WriteLine(num1 + " + " + num2 + " = " + result);
                }
                else if (oper == '-')
                {
                    result = CalculatorOp.Substract (num1, num2);
                    Console.WriteLine(num1 + " - " + num2 + " = " + result);
                }
                else if (oper == '*')
                {
                    result = CalculatorOp.Mult (num1, num2);
                    Console.WriteLine(num1 + " * " + num2 + " = " + result);
                }
                else if (oper == '/')
                {
                    result = CalculatorOp.Division (num1, num2);
                    Console.WriteLine(num1+" / "+num2+ " = " + result);
                }
                else
                {
                    Console.WriteLine("Unknown operator");
                }
                Console.WriteLine("Continue? +/-");
                cont = Convert.ToChar(Console.ReadLine());
            }
        }
    }
}
