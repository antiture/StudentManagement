﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };


            for (int i = 1; i<=luckyNumbers.Length; i++ )
            {
                Console.WriteLine(luckyNumbers[i]); 
            } 

            Console.ReadLine();
            
        }
    }
}
