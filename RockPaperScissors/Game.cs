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
            while(player1.GetWins() < 3 && player2.GetWins() < 3)
            {
                GetMoves();
                CompareMoves();
            }
        }

        public void CompareMoves()
        {
            if (player1.GetMove() == player2.GetMove())
            {
                Console.WriteLine("DRAW!!! Go again.");
                NextTurn();
            } 
            else if (player1.GetMove() == "rock" && (player2.GetMove() == "scissors" || player2.GetMove() == "lizard"))
            {
                player1.PlayerWin();
                Console.WriteLine(player1.GetName() + " chose " + player1.GetMove() + " and " + player2.GetName() + " chose " + player2.GetMove());
                Console.WriteLine(player1.GetName() + " won this round! Score: " + player1.GetName() + " " + player1.wins + "  " + player2.GetName() + " " + player2.wins);
            }
            else if (player1.GetMove() =="paper" && (player2.GetMove() == "rock" || player2.GetMove() == "spock"))
            {
                player1.PlayerWin();
                Console.WriteLine(player1.GetName() + " chose " + player1.GetMove() + " and " + player2.GetName() + " chose " + player2.GetMove());
                Console.WriteLine(player1.GetName() + " won this round! Score: " + player1.GetName() + " " + player1.wins + "  " + player2.GetName() + " " + player2.wins);
            }
            else if (player1.GetMove() == "scissors" && (player2.GetMove() == "paper" || player2.GetMove() == "lizard"))
            {
                player1.PlayerWin();
                Console.WriteLine(player1.GetName() + " chose " + player1.GetMove() + " and " + player2.GetName() + " chose " + player2.GetMove());
                Console.WriteLine(player1.GetName() + " won this round! Score: " + player1.GetName() + " " + player1.wins + "  " + player2.GetName() + " " + player2.wins);
            }
            else if (player1.GetMove() == "lizard" && (player2.GetMove() == "spock" || player2.GetMove() == "paper"))
            {
                player1.PlayerWin();
                Console.WriteLine(player1.GetName() + " chose " + player1.GetMove() + " and " + player2.GetName() + " chose " + player2.GetMove());
                Console.WriteLine(player1.GetName() + " won this round! Score: " + player1.GetName() + " " + player1.wins + "  " + player2.GetName() + " " + player2.wins);
            }
            else if (player1.GetMove() == "spock" && (player2.GetMove() == "scissors" || player2.GetMove() == "rock"))
            {
                player1.PlayerWin();
                Console.WriteLine(player1.GetName() + " chose " + player1.GetMove() + " and " + player2.GetName() + " chose " + player2.GetMove());
                Console.WriteLine(player1.GetName() + " won this round! Score: " + player1.GetName() + " " + player1.wins + "  " + player2.GetName() + " " + player2.wins);
            }
            else
            {
                player2.PlayerWin();
                Console.WriteLine(player1.GetName() + " chose " + player1.GetMove() + " and " + player2.GetName() + " chose " + player2.GetMove());
                Console.WriteLine(player2.GetName() + " won this round! Score: " + player1.GetName() + " " + player1.wins + "  " + player2.GetName() + " " + player2.wins);
            }
            Console.WriteLine("\n\n");
        }
        
        public void GetMoves()
        {
            player1.PickMove();
            player2.PickMove();
        }

        public void DisplayTurnWinner(Player player)
        {

        }
    }
}
