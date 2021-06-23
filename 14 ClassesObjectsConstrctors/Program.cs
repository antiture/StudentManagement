using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //class is just a specification for a new date type : Book
            //object is just a instance of class :  book1
            //constructors is a metode to create a object of this class

            Book book1 = new Book("mike");
            book1.title = "harry potter";
            book1.author="jk";
            book1.pages = 400;

            Book book2 = new Book("john");
            book2.title = "hr";
            book2.author = "La";
            book2.pages = 4000;

            Console.WriteLine(book1.pages);
            Console.WriteLine(book2.author);

            Console.ReadLine();
        }
    }
}
