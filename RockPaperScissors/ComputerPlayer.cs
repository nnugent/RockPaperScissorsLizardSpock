using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
    class ComputerPlayer : Player
    {
        List<string> nameOptions = new List<string> { "The World Destroyer", "Sheldon Cooper", "Darth Vader", "Obi-Wan Kenobi", "WunSwolBoi", "AyeNoDeWea"};
        List<string> moveOptions = new List<string> { "rock", "paper", "scissors", "lizard", "spock" };
        Random rng = new Random();

        public ComputerPlayer()
        {
            name = nameOptions[rng.Next(6)];
        }

        public override string PickMove()
        {
            move = moveOptions[rng.Next(5)];
            return move;
        }
    }
}