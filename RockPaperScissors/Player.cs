using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
    public abstract class Player
    {
        public string move;
        public string name;
        public int wins;

        public virtual string GetMove()
        {
            return "";
        }
    }
}
