using System;

namespace Lottery
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int lott = rnd.Next(1, 11);
            int digit;
            int bingo = 0;
            Console.WriteLine("Guess the number from the range 1-10");

            do
            {
                
                
                Console.Write("Give a number: ");
                digit = int.Parse(Console.ReadLine());
                if (digit < 1 || digit > 10)
                {
                    Console.WriteLine("This number is out of the range");
                }
                else
                {
                    bingo++;
                    if (digit > lott)
                    {
                        Console.WriteLine("This number is too big.");
                    }
                    else if (digit < lott)
                    {
                        Console.WriteLine("This number is too small.");
                    }
                    else
                    {
                        Console.WriteLine("Bingo ! This is correct number: {0} ", digit);
                        Console.WriteLine("You guessed after {0}", bingo);
                    }
                }
            } while (lott != digit);


            Console.ReadKey();
        
        }     
    }
}
