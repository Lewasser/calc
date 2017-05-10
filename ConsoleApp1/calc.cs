using System;

namespace SimpleCalc
{
    class calc 
        {
        static void Main(string[] args)

        {
            char stover = '+';
            while (stover =='+')
            {
                int a;
                int b;
                int result;
                char symb;
                Console.WriteLine("Enter 1st number");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Symbol");
                symb = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Enter 2st number");
                b = Convert.ToInt32(Console.ReadLine());
                if (symb == '+')
                {
                    result = a + b;
                    Console.WriteLine(a + " " + symb + " " + b + " = " + result);
                }
                else if (symb == '-')
                {
                    result = a - b;
                    Console.WriteLine(a + " " + symb + " " + b + " = " + result);
                }
                else if (symb == '*')
                {
                    result = a * b;
                    Console.WriteLine(a + " " + symb + " " + b + " = " + result);
                }
                else if (symb == '/')
                {
                    result = a / b;
                    Console.WriteLine(a + " " + symb + " " + b + " = " + result);
                }
                else
                {
                    Console.WriteLine("Unknown symbol");
                }
                Console.WriteLine("Continue? +/-");
                stover = Convert.ToChar(Console.ReadLine());
            }
            
        }
    }
}
