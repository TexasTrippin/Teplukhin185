using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mak1
{
    public class Calculator
    {
        public static double Calculate(double n1, double n2, string operation)
        {


            if (operation == "+")
            {
                return n1 + n2;
            }
            else if (operation == "-")
            {
                return  n1 - n2;
            }
            else if (operation == "*")
            {
                return n1 * n2;
            }
            else if (operation == "/")
            {
                if (n2 != 0)
                    return n1 / n2;
                else Console.WriteLine("Неизвестный оператор");
            }



            return 0;



        }
        static void Main(string[] args)
        {
           
            Console.WriteLine("Введите первое число:");
            double n1 = Int32.Parse(Console.ReadLine());

            Console.Write("\nВведите оператор:");
            string operation = Console.ReadLine();

            Console.Write("\nВведите второе число:");
            double n2 = Int32.Parse(Console.ReadLine());

            double res = Calculator.Calculate(n1, n2, operation );
            Console.WriteLine("Результат = " + res);

            

        }
    }
}