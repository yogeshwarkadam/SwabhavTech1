using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesserGame2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            
            int randomNumber = random.Next(1, 100);
            int guess;
            int numberOfGuesses = 10;
            bool gameOver = false;
            int attempt = 0;
           
            while(!gameOver )
            {
                Console.WriteLine("guess the number between 1 to 100");
                guess = Convert.ToInt32(Console.ReadLine());
                numberOfGuesses--;
                attempt = attempt + 1;


                if (guess!= randomNumber && numberOfGuesses ==0)
                {
                    Console.WriteLine("You lost the game...");
                    gameOver = true;
                }
                else if(guess ==randomNumber)
                {
                   
                    Console.WriteLine("Congratulations...You win the game in attempt " +attempt);
                    Console.WriteLine("do you want to Play again... yes OR no");
                    string YesorNo = Console.ReadLine();
                    if (YesorNo=="yes")
                    {
                        randomNumber = random.Next(1, 100);
                        attempt = 0;
                        numberOfGuesses = 10;

                        Console.Clear();
                        
                    }
                    else
                    {
                        gameOver = true;
                    }
                   
                }
                else if(guess > randomNumber)
                {
                    Console.WriteLine("Entered number is higher");
                }
                else if (guess < randomNumber)
                {
                    Console.WriteLine("Entered number is lower");
                }
            }

            Console.ReadLine();

        }
    }
}
