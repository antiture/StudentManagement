using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodes
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHi("max", 32);
            SayHi("leo", 26);
            SayHi("etienne", 24);

            Console.ReadLine();
        }
        static void SayHi(string name , int age)
        {
            Console.WriteLine("hello " + name + age);
        }
    }
}
