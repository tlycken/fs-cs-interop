using RPS.IO;
using RPS.Scoring;

namespace RPS.Program
{
    class Program
    {
        static void Main(string[] args)
        {
            var playerOne = new Player(Console.Prompt("Who is player one?"));
            var playerTwo = new Player(Console.Prompt("Who is player two?"));

            Interop.PlayGame(playerOne, playerTwo);
        }
    }
}
