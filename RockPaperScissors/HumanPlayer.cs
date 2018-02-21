using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
    class HumanPlayer : Player
    {
        public HumanPlayer()
        {
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            wins = 0;
        }
        public override string PickMove()
        {
            Console.WriteLine("Rock, Paper, Scissors, Lizard, or Spock?");
            move = Console.ReadLine().ToLower();
            Console.WriteLine();
            return move;
        }
    }
}
