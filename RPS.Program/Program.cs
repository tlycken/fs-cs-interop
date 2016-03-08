using RPS.Scoring;

namespace RPS.Program
{
    class Program
    {
        static void Main(string[] args)
        {
            var playerOne = new Player(IO.IO.Prompt("Who is player one?"));
            var playerTwo = new Player(IO.IO.Prompt("Who is player two?"));

            Interop.PlayGame(playerOne, playerTwo);
        }
    }
}
