using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettersSetters
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie avengers = new Movie("the avengers", "joss", "pg-13");
            Movie angrymen = new Movie("angrymen", "silu", "pg");

            

            Console.WriteLine(angrymen.title +" " + angrymen.Rating);

            angrymen.Rating = "dog";
            Console.WriteLine(angrymen.title + " " + angrymen.Rating);

            Console.ReadLine();

        }
    }
}
