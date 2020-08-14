using System;
/// <summary>
/// An Unimaginative Guess the number engine
/// Deliberatly dumb.
/// With some deliberate logic
/// </summary>
namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random nGenerator = new Random(123);
            //Some error trapping
            if (args.Length == 0)
            {
                Console.WriteLine("GuessTheNumber requires 2 parameters the first is the number of guesses, the second is the max number I pick from.");
                return;
            }

            int numberOfTries = int.Parse(args[0]);
            int ceiling = int.Parse(args[1]);


            int myNumber = nGenerator.Next(ceiling);

            string playerGuess="";
            int playerGuessNum = 0;
            Console.WriteLine("I am thinking of a whole number between 0 and 20");
            Console.WriteLine("Can you try and guess it in less than 5 tries ?");

            for(int i = numberOfTries; i > 0 && playerGuessNum!=myNumber; i--)
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
                    Console.WriteLine($"Well Done. You took {i} attempts.");
                }             
            }
            Console.WriteLine("Too bad you didn't guess it, I'm just too smart.");
        }
    }
}
