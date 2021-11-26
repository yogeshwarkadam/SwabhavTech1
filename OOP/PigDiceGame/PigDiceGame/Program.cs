using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigDiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            bool gameOver = false;
            int totalPoints = 0;
            for (int turn = 1; gameOver != true; turn++)
            {
                int scoreForTurn = 0;
                Console.WriteLine();
                
                Console.WriteLine("TURN "+turn);
               
                while (true)
                {
                    Console.WriteLine("Roll or hold? (r/h):");
                    string rollOrDice = Console.ReadLine();

                    if (rollOrDice == "r")
                    {
                        Random random = new Random();
                        int newPoint = random.Next(1, 6);
                        Console.WriteLine("Die: " + newPoint);
                        if (newPoint == 1)
                        {
                            // totalPoints = 0;
                            scoreForTurn = 0;
                            Console.WriteLine("Turn over. No score.");
                            break;
                        }
                        totalPoints = totalPoints + newPoint;
                        scoreForTurn = scoreForTurn + newPoint;
                    }
                    else if (rollOrDice == "h")
                    {
                        Console.WriteLine("Score for the turn: " + scoreForTurn);
                        Console.WriteLine("Total Score: " + totalPoints);

                        if (totalPoints >= 20)
                        {
                            Console.WriteLine("Congratulations!!! You completed game in turn " + turn);
                            gameOver = true;
                            break;
                        }
                        break;
                    }
                }

                
            }
            Console.ReadKey();
        }
    }
}
