using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 11);
            int guess = 0;
            string answer;
            int IsThisCorrectGuess = 1;
            Console.WriteLine("Welcome To The Number Guessing Game <3");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Computer will be generate a number between 1 and 10.");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("If you guess the number correctly YOU WILL BE REWARDED HUN!!");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("You have three chances to guess the correct number ");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("If you fail, I HAVE TO PUNISH YOU!");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Good Luck <3");
            System.Threading.Thread.Sleep(2000);

            Console.WriteLine("Ready to make your first guess? If you feel ready please say yes :)");
            answer = Console.ReadLine();
            if (answer == "yes")
            {
                Console.WriteLine("Then go ahead and make your guess.. ");
                guess = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("SO YOU DON'T WANT TO PLAY MY GAME. GET OUT!");
                System.Threading.Thread.Sleep(1000);
                Environment.Exit(0);
                //if youre not gonna play then you dont have to stay :)
            }

            while (IsThisCorrectGuess <= 2)
            {   //if you wanna see what nmber did computer genarate you can use the code below
                //Console.WriteLine(randomNumber.ToString());
                
                if (guess == randomNumber)
                {
                    Console.WriteLine("Congratulations! You guessed the correct number! Now it's time for reward");
                    Console.WriteLine("  /\\_/\\  ");
                    Console.WriteLine("  ( o.o ) ");
                    Console.WriteLine("   > ^ <  ");
                    Console.WriteLine("here is a cat for your hard work. his name is jeff, take care of him <3");
                    Console.ReadKey();
                    break;
                }

                else if (guess <= randomNumber)
                {
                    Console.WriteLine("TRY again. Your guess is too low. ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    IsThisCorrectGuess++;
                }
                else if (guess >= randomNumber)
                {
                    Console.WriteLine("TRY again. Your guess is too high. ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    IsThisCorrectGuess++;
                }
            }
            
            if (guess != randomNumber)
            { 
           
                Console.WriteLine("You didn't make it in three guesses. I'm gonna send you a ghost named Jack.");
                Console.WriteLine("       .-.");
                Console.WriteLine("      (o o) ");
                Console.WriteLine("      | O | ");
                Console.WriteLine("      |   | ");
                Console.WriteLine("      '~~~' ");
                Console.WriteLine("        |     ");
                Console.WriteLine("       / \\   ");
                Console.WriteLine("      /   \\  ");
                Console.ReadKey();
               

            }
        
        }
    }
}

                    