using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.CreatePlayers(game.GetGameMode());
            game.Start();
        }
    }
}
