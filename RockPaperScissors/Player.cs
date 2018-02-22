using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
    public abstract class Player
    {
        protected string move;
        protected string name;
        protected int wins;

        public virtual string GetMove()
        {
            return move;
        }

        public abstract string PickMove();

        public void PlayerWin()
        {
            wins++;
        }

        public string GetName()
        {
            return name;
        }

        public int GetWins()
        {
            return wins;
        }

        public void ResetWins()
        {
            wins = 0;
        }
    }
}
