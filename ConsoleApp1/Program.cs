/// Chapter No. 3		Exercise No. 2
/// File Name: MainWindow.cs
/// @author: Marcus Moore
/// Date:  September 27, 2021
///
/// Problem Statement: Create a program that calculates the statistics of
///                    eight coin tosses, after the user inputs all 8 tosses.
/// 
/// Overall Plan:
/// 1) Create a string called tosses.
/// 2) Prompt the user to enter either an h or t for heads and tails.
/// 3) Store each h and t in tosses.
/// 4) Create two ints, one called heads and one called tails.
/// 5) Loop through tosses, incrementing heads for each h and tails for each t.
/// 6) Create two floats called head_perc and tail_perc.
/// 7) Set head_perc to heads divided by 8.
/// 8) Set tail_perc to tails divided by 8.
/// 9) Display all information.
/// 
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! This program will calculate the percentage of heads versus tails after 8 tosses.");
            Console.WriteLine("Use 'H' to represent heads and 'T' to represent tails.");

            string tosses = "";

            for (int toss = 0; toss < 8; toss++)
            {
                Console.WriteLine("Enter toss " + (toss + 1) + ":");
                tosses += Console.ReadLine();
            }

            tosses = tosses.ToLower();

            int heads = 0, tails = 0;
            for (int c = 0; c < 8; c++)
            {
                if (tosses[c] == 'h')
                {
                    heads++;
                }
                else if (tosses[c] == 't')
                {
                    tails++;
                }
            }

            double head_perc, tail_perc;

            head_perc = heads / 8.0 * 100;
            tail_perc = tails / 8.0 * 100;

            Console.WriteLine("Number of Heads: " + heads);
            Console.WriteLine("Number of Tails: " + tails);
            Console.WriteLine();
            Console.WriteLine("Percentage of Heads: " + head_perc);
            Console.WriteLine("Percentage of Tails: " + tail_perc);
        }
    }
}
