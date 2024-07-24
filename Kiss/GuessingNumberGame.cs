namespace Kiss;

public class GuessingNumberGame
{
    private readonly int _minGuessNumber;
    private readonly int _maxGuessNumber;
    private int _randomNumber;

    public GuessingNumberGame(int minGuessNumber, int maxGuessNumber)
    {
        _minGuessNumber = minGuessNumber;
        _maxGuessNumber = maxGuessNumber;
    }

    public void StartGame()
    {
        GenerateRandomNumber();
        AskForTheGuessedNumber();
    }

    private void GenerateRandomNumber()
    {
        _randomNumber = NumberGenerator
                    .GenerateRandomNumber(_minGuessNumber, _maxGuessNumber);
        NumberDisplayer.DisplayGuessNumberRange(_minGuessNumber, _maxGuessNumber);
    }

    private void AskForTheGuessedNumber()
    {
        bool wasGuessed;
        int currentUserNumber;
        do
        {
            currentUserNumber = UserInputHandler.GetGuessedNumber();
            wasGuessed = NumberValidator.IsTheNumber(currentUserNumber, _randomNumber);

            if (!wasGuessed)
            {
                NumberValidator.GiveClue(currentUserNumber, _randomNumber);
            }
        } while (!wasGuessed);
    }

}
