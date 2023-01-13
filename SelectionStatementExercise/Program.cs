using System.Diagnostics;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Create a random favorite number
            var r = new Random();
            var favNumber = r.Next(1, 1000);
            //Prompt user to guess a number
            Console.WriteLine("Guess my favorite number.");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber) //guess is too low
            {
                Console.WriteLine("too low.");
            }
            else if (userInput > favNumber) //guess is too high
            {
                Console.WriteLine("too high");
            }
            else //guess is correct
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}
