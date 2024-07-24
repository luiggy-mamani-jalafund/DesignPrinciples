namespace Yagni;

public static class FilePathValidator
{
    public static void ValidateFilePathOnArgs(string[] args)
    {
        if (args.Length == 0)
        {
            throw new ArgumentNullException(
                "Please add the file path as the app argument"
            );
        }
    }

    public static void ValidateFilePath(string filePath)
    {
        if (!File.Exists(filePath))
        {
            throw new FileNotFoundException(
                "The specified file does not exist."
            );
        }
    }
}