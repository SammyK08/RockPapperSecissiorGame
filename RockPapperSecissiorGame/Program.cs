using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPapperSecissiorGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput, computerInput;
            int randomInput = 0;
           int computerWin = 0;
          int  playerWin = 0;

            bool Continue = true;
            do
            {
                Random rmd = new Random();
                randomInput = rmd.Next(1, 4);


                Console.WriteLine("please choose ROCK PAPPER SESSIOR");
                userInput = Console.ReadLine();

                switch (randomInput)
                {

                    case 1:
                        computerInput = "ROCK";
                        if (userInput.Equals("ROCK", StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine("Game Draws !!!");
                        }
                        else if (userInput.Equals("SESSIOR", StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine("You Loose");
                            computerWin++;

                        }
                        else if (userInput.Equals("PAPPER", StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine("You Win");
                            playerWin++;
                        }
                        break;

                    case 2:
                        computerInput = "SESSIOR";
                        if (userInput.Equals("ROCK", StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine("You Win");
                            playerWin++;
                        }
                        else if (userInput.Equals("SESSIOR", StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine("Game Draws");


                        }
                        else if (userInput.Equals("PAPPER", StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine("You Loose");
                            computerWin++;

                        }
                        break;

                    case 3:
                        computerInput = "PAPPER";
                        if (userInput.Equals("ROCK", StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine("You LOOSE");
                            computerWin++;
                        }
                        else if (userInput.Equals("SESSIOR", StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine("You Win!!!");
                            playerWin++;


                        }
                        else if (userInput.Equals("PAPPER", StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine("You Draw");


                        }
                        break;

                    default:
                        Console.WriteLine("no valid input");
                        break;

                }

                Console.WriteLine("Do you want to continue game Y/N");
                var decision = Console.ReadLine();

                Continue= decision.Equals("Y", StringComparison.OrdinalIgnoreCase);
                

            } while (Continue);

            Console.WriteLine("Final Result");
            Console.WriteLine("computer win {0}",computerWin);
            Console.WriteLine("Player Win {0}",playerWin);
            if (computerWin > playerWin)
            {
                Console.WriteLine("You Loose");
            }
            else if (computerWin < playerWin)
            {
                Console.WriteLine("You Win CONGRATS");
            }
            else
            {
                Console.WriteLine("you draw");
            }
            Console.ReadLine();

        }
    }
}
