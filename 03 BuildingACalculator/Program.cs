using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingACalculator
{
    class Program
    {
       



        static void Main(string[] args)
        { 
            int num = Convert.ToInt32( "45");
            Console.WriteLine(num + 6);

            Console.WriteLine("enter a number");
            int num1 = Convert.ToInt32( Console.ReadLine());

            Console.WriteLine("enter a another number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num1 + num2);

            Console.ReadLine(); 
        }
    }
}
