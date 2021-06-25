using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingUserInput
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();
            Console.WriteLine("hi " + name);
             
            Console.ReadLine();
        }
    }
}
