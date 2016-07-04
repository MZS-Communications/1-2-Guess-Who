using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One_2GuessWho
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int val = r.Next(1, 100);
            int guess = 0;
            int numGuesses = 0;
            bool correct = false;

            Console.WriteLine("I'm thinking of a number between 1 and 100.");



            for (int i = 0; i < 10; i++)
            {
                if (i < 10)
                {
                    Console.Write("Guess: ");
                    string input = Console.ReadLine();
                    ;
                    if (!int.TryParse(input, out guess))
                    {
                        Console.WriteLine("That's not a number.");
                        continue;
                        numGuesses++;
                    }

                    if (guess < val)
                    {
                        Console.WriteLine("No, the number I'm thinking is higher than that number.");
                        numGuesses++;
                    }
                    else if (guess > val)
                    {
                        Console.WriteLine("No, the number I'm thinking is lower than that number.");
                        numGuesses++;
                    }
                    else
                    {
                        numGuesses++;
                        correct = true;

                        Console.WriteLine("Well done,You guessed right!");
                        Console.WriteLine(".\nYou took " + numGuesses + " guesses.");
                        Console.WriteLine("Would you like to play again Y/N?");
                        char test = 'y';
                        char de = Convert.ToChar(Console.ReadLine());

                        if (test == de)
                        {
                            i = 0;
                            Console.WriteLine("I'm thinking of a number between 1 and 100.");

                        }
                        else
                        {
                            Console.WriteLine("Thank You for Playing, hope you had fun");
                        }
                        Console.ReadKey();
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("You have no more attempts");
                    Console.WriteLine();
                    Console.WriteLine("Would you like to try again Y/N?");
                    char test = 'y';
                    char input = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine("I'm thinking of a number between 1 and 100.");
                    if (test == input)
                    {
                        i = 0;
                    }
                    else
                    {
                        Console.WriteLine("Thank You for Playing, hope you had fun");
                    }
                    Console.ReadKey();
                }
            }

        }


    }
}


