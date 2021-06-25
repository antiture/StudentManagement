using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingAGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "giraffe";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            while ( guess != secretWord && !outOfGuesses )
            { 
                if(guessCount < guessLimit)
                {
                    Console.WriteLine("enter guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;
                } 
            }
            if(outOfGuesses)
            {
                Console.WriteLine("you lose");
            }
            else
            {
                Console.WriteLine("you win!");
            }
             

            Console.ReadLine();
        }
    }
}
