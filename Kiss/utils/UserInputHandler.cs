namespace Kiss;

public static class UserInputHandler
{
    public static int GetGuessedNumber()
    {
        Console.Write("Enter your guess number: ");
        var input = Console.ReadLine();
        if (int.TryParse(input, out int guessNumber))
        {
            return guessNumber;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.\n");
            return GetGuessedNumber();
        }
    }
}