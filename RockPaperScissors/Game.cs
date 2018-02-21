using System;
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
            Console.WriteLine("Would you like to play 2 player or 1 player?" + System.Environment.NewLine +"Enter 1 or 2.");
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
        
        public void NextTurn()
        {
            while(player1.wins < 3 && player2.wins < 3)
            {
                player1.GetMove();
                player2.GetMove();
                CompareMoves();
            }
        }

        public void CompareMoves()
        {
            if (player1.move == player2.move)
            {
                Console.WriteLine("DRAW!!! Go again.");
            } 
            else if (player1.move == "rock" && (player2.move == "scissors" || player2.move == "lizard"))
            {
                player1.PlayerWin();
                Console.WriteLine(player1.name + " chose " + player1.move + " and " + player2.name + " chose " + player2.move);
                Console.WriteLine(player1.name + " won this round! Score: " + player1.name + " " + player1.wins + "  " + player2.name + " " + player2.wins);
            }
            else if (player1.move =="paper" && (player2.move == "rock" || player2.move == "spock"))
            {
                player1.PlayerWin();
                Console.WriteLine(player1.name + " chose " + player1.move + " and " + player2.name + " chose " + player2.move);
                Console.WriteLine(player1.name + " won this round! Score: " + player1.name + " " + player1.wins + "  " + player2.name + " " + player2.wins);
            }
            else if (player1.move == "scissors" && (player2.move == "paper" || player2.move == "lizard"))
            {
                player1.PlayerWin();
                Console.WriteLine(player1.name + " chose " + player1.move + " and " + player2.name + " chose " + player2.move);
                Console.WriteLine(player1.name + " won this round! Score: " + player1.name + " " + player1.wins + "  " + player2.name + " " + player2.wins);
            }
            else if (player1.move == "lizard" && (player2.move == "spock" || player2.move == "paper"))
            {
                player1.PlayerWin();
                Console.WriteLine(player1.name + " chose " + player1.move + " and " + player2.name + " chose " + player2.move);
                Console.WriteLine(player1.name + " won this round! Score: " + player1.name + " " + player1.wins + "  " + player2.name + " " + player2.wins);
            }
            else if (player1.move == "spock" && (player2.move == "scissors" || player2.move == "rock"))
            {
                player1.PlayerWin();
                Console.WriteLine(player1.name + " chose " + player1.move + " and " + player2.name + " chose " + player2.move);
                Console.WriteLine(player1.name + " won this round! Score: " + player1.name + " " + player1.wins + "  " + player2.name + " " + player2.wins);
            }
            else
            {
                player2.PlayerWin();
                Console.WriteLine(player1.name + " chose " + player1.move + " and " + player2.name + " chose " + player2.move);
                Console.WriteLine(player2.name + " won this round! Score: " + player1.name + " " + player1.wins + "  " + player2.name + " " + player2.wins);
            }
            Console.WriteLine("\n\n");
        }
    }
}
