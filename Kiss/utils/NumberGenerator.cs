namespace Kiss;

public class NumberGenerator
{
    public static int GenerateRandomNumber(int min, int max)
    {
        return new Random().Next(min, max + 1);
    }

}
