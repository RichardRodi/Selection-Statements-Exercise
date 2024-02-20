using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)

        {
            var r = new Random();
            var favNumber = r.Next(1, 100);
            var counter = 0;
            int userInput;
            

                do
                {
                
                Console.WriteLine("Guess a Number From 1-100");

                userInput = int.Parse(Console.ReadLine());

                if (userInput < favNumber)
                {
                    Console.WriteLine($"{userInput} is Too Low!");
                }
                else if (userInput > favNumber)
                {

                    Console.WriteLine($"{userInput} is Too High!");
                }
                else  
                {
                    Console.WriteLine("You Guessed It");

                }
                counter++;

                    Console.WriteLine($"You guessed {counter} times");

            }   while (userInput != favNumber); 
        }
    }
}
