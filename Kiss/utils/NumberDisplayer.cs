namespace Kiss;

public static class NumberDisplayer
{
    public static void DisplayGuessNumberRange(int minNumber, int maxNumber)
    {
        Console.WriteLine($"I'm thinking of a number between {minNumber} and {maxNumber}.");
        Console.WriteLine("Try to guess.\n");
    }
}