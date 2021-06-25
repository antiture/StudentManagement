using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingABetterCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter a number ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("enter operator ");
            string op = Console.ReadLine();

            Console.Write("enter a number ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+")
            {
                Console.WriteLine(num1 + num2);
            }else if(op == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            else if (op == "/")
            {
                Console.WriteLine(num1 / num2);
            }
            else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else
            {
                Console.WriteLine("Invalide Opperator");
            }






            Console.ReadLine();
        }
    }
}
