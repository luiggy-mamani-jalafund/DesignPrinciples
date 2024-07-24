namespace Yagni;

public static class FileReader
{

    public static string GetPathFromArgs(string[] args)
    {
        FilePathValidator.ValidateFilePathOnArgs(args);
        return args[0];
    }

    public static string ReadFile(string filePath)
    {
        FilePathValidator.ValidateFilePath(filePath);
        return File.ReadAllText(filePath);
    }


}