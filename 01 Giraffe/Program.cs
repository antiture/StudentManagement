using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe2
{
    class Program
    {
        static void Main(string[] args)
        { 
            char grade = 'A';
            Console.WriteLine( "helloword\n" + grade);
            Console.WriteLine("helloword\n" + "\"" + grade);


            string phrase = "Giraffe Academy";
            Console.WriteLine("ToLower " + phrase.ToLower());
            Console.WriteLine("Contains(\"Academy\") " + phrase.Contains("Academy"));
            Console.WriteLine( "[] " + phrase[0]);
            Console.WriteLine("Substring(8,3) " + phrase.Substring(8, 3));

            Console.WriteLine("Math.Pow(8,3) " + Math.Pow(8, 3));
            Console.WriteLine("Math.Max(8,3) " + Math.Max(8, 3));
            Console.WriteLine("Math.Round(8.3) " + Math.Round(8.3));

            Console.Write(" Enter your name:");
            string userName =  Console.ReadLine();
            Console.Write("Hello " + userName);













            Console.ReadLine();

        }
    }
}
