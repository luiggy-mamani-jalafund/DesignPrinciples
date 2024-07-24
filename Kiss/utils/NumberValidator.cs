namespace Kiss;

public static class NumberValidator
{
    public static bool IsTheNumber(int guess, int correctNumber)
    {
        if (guess == correctNumber)
        {
            Console.WriteLine("You guessed the number!");
            return true;
        }
        return false;
    }

    public static void GiveClue(int guess, int correctNumber)
    {
        if (guess < correctNumber)
        {
            Console.WriteLine("The number should be greater.\n");
        }
        else if (guess > correctNumber)
        {
            Console.WriteLine("The number should be smaller.\n");
        }
    }
}