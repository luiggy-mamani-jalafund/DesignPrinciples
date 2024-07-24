namespace Yagni;

public static class WordCounter
{
    private static readonly char[] SPLITTERS = [' ', '\n', '\r', '\t'];

    public static int CountWords(string content)
    {
        if (string.IsNullOrWhiteSpace(content))
        {
            return 0;
        }

        string[] words = content.Split(
            SPLITTERS,
            StringSplitOptions.RemoveEmptyEntries);
            
        return words.Length;
    }
}