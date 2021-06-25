using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassAttributes
{
    class Program
    {
        static void Main(string[] args)
        {


            Song holiday = new Song("Holiday", "Green Day", 400);
            Song Kashimir = new Song("Kashimir", "Led", 120);

            Console.WriteLine(holiday.title);
            Console.WriteLine(Kashimir.title);

            Console.WriteLine(Song.songCount);  //可以通过类直接输出

            Console.WriteLine(Kashimir.getSongCount()); //通过方法传输



            Console.ReadLine();
        }
    }
}
