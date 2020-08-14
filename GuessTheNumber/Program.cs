using System;
/// <summary>
/// An Unimaginative Guess the number engine
/// Deliberatly dumb.
/// </summary>
namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random nGenerator = new Random(123);
            int myNumber = nGenerator.Next(20);

            string playerGuess="";
            int playerGuessNum = 0;
            Console.WriteLine("I am thinking of a whole number between 0 and 20");
            Console.WriteLine("Can you try and guess it in less than 5 tries ?");

            for(int i = 5; i > 0 && playerGuessNum!=myNumber; i--)
            {
                Console.WriteLine("You have " + i.ToString() + " tries left.");
                Console.WriteLine("Take a guess ?");
                playerGuess= Console.ReadLine();
                playerGuessNum = int.Parse(playerGuess);
                if (playerGuessNum > myNumber)
                {
                    Console.WriteLine("Too High, Try again.");
                }
                else if (playerGuessNum<myNumber)
                {
                    Console.WriteLine("Too Low, Try again.");
                }
                else
                {
                    Console.WriteLine("Well Done.");
                }             
            }
        }
    }
}
