using System.ComponentModel.Design;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 1000);
            Console.WriteLine("Try to guess my favorite number. Its a number between 1 and 1,000:");
            var userInput = int.Parse(Console.ReadLine());
            Console.WriteLine();
         
      
      
            if (userInput < favNumber)
            {
                Console.WriteLine("too low");
                Console.WriteLine();
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("too high");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("You guessed it!!!");
                Console.WriteLine();
            }

            do
            {
                Console.WriteLine("Try to guess my favorite number");
                userInput = int.Parse(Console.ReadLine());

                if (userInput < favNumber)
                {
                    Console.WriteLine("too low");
                    Console.WriteLine();
                }
                else if (userInput > favNumber)
                {
                    Console.WriteLine("too high");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("You guessed it!!!");
                    Console.WriteLine();
                }
            }
            while (userInput != favNumber);
            
               
         


        }
    }
}
