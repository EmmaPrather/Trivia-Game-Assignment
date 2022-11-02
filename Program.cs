using System;

namespace TriviaGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.Name = "Trivia Game";
            game.Start();
        }
    }
}
