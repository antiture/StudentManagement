using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_IfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isMale = false;
            bool isTall = true;

            if (isMale && isTall)
            {
                Console.WriteLine("tall male");
            }
            else if (isMale && !isTall)
            {
                Console.WriteLine("short male");
            }
            else if (!isMale && isTall)
            {
                Console.WriteLine("tall girl");
            }
            else
            {
                Console.WriteLine("short girl");
            }


            Console.ReadLine();
        }
    }
}
