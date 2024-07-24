namespace Yagni;

class Program
{
    static void Main(string[] args)
    {
        string filePath = FileReader.GetPathFromArgs(args);
        string fileContent = FileReader.ReadFile(filePath);
        int wordCount = WordCounter.CountWords(fileContent);
        Console.WriteLine($"The file contains {wordCount} words.");
    }
}