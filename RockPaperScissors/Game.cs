using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
    class Game
    {
        Player player1;
        Player player2;
        public string GetGameMode()
        {
            string choice = "";
            bool invalidInput = true;
            while (invalidInput)
            {
                Console.WriteLine("Would you like to play 1 player or 2 player?" + Environment.NewLine + "Enter 1 or 2.");
                choice = Console.ReadLine();
                if (choice == "1" || choice =="2")
                {
                    invalidInput = false;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input, try again.");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            return choice;
        }

        public void CreatePlayers(string numberOfPlayers)
        {
            if (numberOfPlayers == "1")
            {
                player1 = new HumanPlayer();
                player2 = new ComputerPlayer();
            }
            else
            {
                Console.WriteLine("Player 1:\n");
                player1 = new HumanPlayer();
                Console.WriteLine("Player 2:\n");
                player2 = new HumanPlayer();
            }
        }
        
        public void Start()
        {
            DisplayOpponents();
            do
            {
                ResetWins();
                while (player1.GetWins() < 3 && player2.GetWins() < 3)
                {
                    GetMoves();
                    DisplayChoices();
                    DisplayTurnWinner(GetTurnWinner());
                }
                DisplayRoundWinner();
            } while (PlayAgain());
        }

        public Player GetTurnWinner()
        {
            if (player1.GetMove() == player2.GetMove())
            {
                return player1;
            } 
            else if (player1.GetMove() == "rock" && (player2.GetMove() == "scissors" || player2.GetMove() == "lizard"))
            {
                player1.PlayerWin();
                return player1;
            }
            else if (player1.GetMove() == "paper" && (player2.GetMove() == "rock" || player2.GetMove() == "spock"))
            {
                player1.PlayerWin();
                return player1;
            }
            else if (player1.GetMove() == "scissors" && (player2.GetMove() == "paper" || player2.GetMove() == "lizard"))
            {
                player1.PlayerWin();
                return player1;
            }
            else if (player1.GetMove() == "lizard" && (player2.GetMove() == "spock" || player2.GetMove() == "paper"))
            {
                player1.PlayerWin();
                return player1;
            }
            else if (player1.GetMove() == "spock" && (player2.GetMove() == "scissors" || player2.GetMove() == "rock"))
            {
                player1.PlayerWin();
                return player1;
            }
            else
            {
                player2.PlayerWin();
                return player2;
            }
        }
        
        public void GetMoves()
        {
            player1.PickMove();
            player2.PickMove();
        }

        public void DisplayTurnWinner(Player player)
        {
            if (player1.GetMove() == player2.GetMove())
            {
                Console.WriteLine("Draw!!! Nobody Wins!");
                Console.WriteLine(player1.GetName() + ": " + player1.GetWins() + "     " + player2.GetName() + ": " + player2.GetWins());
            }
            else
            {
                Console.WriteLine(player.GetName() + " won this round!!!");
                Console.WriteLine(player1.GetName() + ": " + player1.GetWins() + "     " + player2.GetName() + ": " + player2.GetWins());
            }
            Console.ReadLine();
            Console.Clear();
        }

        public void DisplayRoundWinner()
        {
            if (player1.GetWins() == 3)
            {
                Console.WriteLine(player1.GetName() + " is the Winner!!!");
            }
            else
            {
                Console.WriteLine(player2.GetName() + " is the Winner!!!");
            }
            Console.ReadLine();
        }

        public bool PlayAgain()
        {
            bool invalidInput = true;
            string again = "";
            while (invalidInput)
            {
                Console.WriteLine("Would you like to play again?\nEnter 'yes' or 'no'.");
                again = Console.ReadLine().ToLower();
                if (again == "yes")
                {
                    Console.Clear();
                    return true;
                }
                else if(again == "no")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Invalid input, try again.");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            return false;
        }

        public void ResetWins()
        {
            player1.ResetWins();
            player2.ResetWins();
        }

        public void DisplayChoices()
        {
            Console.WriteLine(player1.name + " chose " + player1.GetMove() + " and " + player2.GetName() + " chose " + player2.GetMove() + ".");
        }

        public void DisplayOpponents()
        {
            Console.Clear();
            Console.WriteLine(player1.GetName() + "   versus   " + player2.GetName());
            Console.ReadLine();
        }
    }
}
