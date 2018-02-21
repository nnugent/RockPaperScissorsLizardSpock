using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
    class HumanPlayer : Player
    {
        public HumanPlayer()
        {
            Console.Clear();
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            wins = 0;
        }
        public override string PickMove()
        {
            bool invalidInput = true;
            while (invalidInput)
            {
                Console.Clear();
                Console.WriteLine("Rock, Paper, Scissors, Lizard, or Spock?");
                move = Console.ReadLine().ToLower();
                if (move == "rock" || move == "paper" || move == "scissors" || move == "lizard" || move == "spock")
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
            Console.Clear();
            return move;
        }
    }
}
