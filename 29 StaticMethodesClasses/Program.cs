using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethodesClasses
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Math.Sqrt(144)); //exemple of statique classes methodes

            //UsefulTools tools = new UsefulTools();    //can not create an instance of a static class
            UsefulTools.SayHi("Mike");
             
            Console.ReadLine(); 

        }
    }
}
