﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
    class Game
    {
        Player player1;
        Player player2;
        public void GetUsers()
        {
            Console.WriteLine("Would you like to play 1 player or 2 player?" + System.Environment.NewLine +"Enter 1 or 2.");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                player1 = new HumanPlayer();
                player2 = new ComputerPlayer();
            }
            else
            {
                player1 = new HumanPlayer();
                player2 = new HumanPlayer();
            }
        }
        
        public void Start()
        {
            ResetWins();
            do
            {
                while (player1.GetWins() < 3 && player2.GetWins() < 3)
                {
                    GetMoves();
                    DisplayTurnWinner(GetTurnWinner());
                }
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
                Console.WriteLine(player.GetName() + " won this round!! \n");
                Console.WriteLine(player1.GetName() + ": " + player1.GetWins() + "     " + player2.GetName() + ": " + player2.GetWins());
            }
            Console.WriteLine("\n\n");
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
        }

        public bool PlayAgain()
        {
            Console.WriteLine("Would you like to play again?\nEnter 'yes' or 'no'.");
            string again = Console.ReadLine();
            if(again == "yes")
            {
                return true;
            }
            return false;
        }

        public void ResetWins()
        {
            player1.ResetWins();
            player2.ResetWins();
        }
    }
}
