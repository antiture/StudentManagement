using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettersSetters
{
    class Movie
    {
        public string title;
        public string director;
        private string rating; //private!!!!!!

        public Movie(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            rating = aRating;

            Console.WriteLine("creating movie " + aTitle);
        }

        public string Rating
        {
            get { return rating; }
            set { 
                if(value == "g" || value == "pg" || value == "pg-13")
                {
                    rating = value;
                }
                else
                {
                    rating = "nr";
                }
            
            }
        }


    }
}
