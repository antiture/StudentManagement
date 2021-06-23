using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjects
{
    class Book
    {
        public string title ;
        public string author ;
        public int pages ;

        //constructors is a metode to create a object of this class
        //每次出现new Book就会执行 
        public Book(string aTitle, string aAuthor, int aPages)
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;

            Console.WriteLine("creating book" + aTitle + aAuthor + aPages);
        }
    }
}
