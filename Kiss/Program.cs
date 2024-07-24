namespace Kiss;

class Program
{
    static void Main(string[] args)
    {
        GuessingNumberGame guessingNumberGame = new GuessingNumberGame(0, 100);
        guessingNumberGame.StartGame();
    }
}