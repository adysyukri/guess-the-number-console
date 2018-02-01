using System;

namespace guess_the_number_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int guessesTaken = 0;

            Console.WriteLine("Hello! What is your name?");

            string myName = Console.ReadLine();

            Random random = new Random();

            int number = random.Next(1,21);

            Console.WriteLine("Well, " + myName + ", I am thinking of a number between 1 and 20.");
            int guess = 0;

            while (guessesTaken < 6){
                Console.WriteLine("Take a guess. ");

                guess = Int32.Parse(Console.ReadLine());

                guessesTaken++;

                if (guess < number){
                    Console.WriteLine("Your guess is too low.");
                }
                if (guess > number){
                    Console.WriteLine("Your guess is too high.");
                }
                if (guess == number){
                    break;
                }
                
            }

            if (guess == number){
                Console.WriteLine("Good job, " + myName + "! You guessed my number in " + guessesTaken + " guesses!");
            }

            if (guess != number){
                Console.WriteLine("Nope. The number I was thinking of was " + number);
            }
        }
    }
}
