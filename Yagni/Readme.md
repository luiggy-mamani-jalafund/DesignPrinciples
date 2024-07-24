# WORD COUNTER PROGRAM

This program counts the words in a provided text file (.txt). It applies the YAGNI (You Aren't Gonna Need It) principle by focusing only on the essential functionality required.

## Application of the YAGNI Principle

### Implemented Functionalities

The goal is real a txt file and count the words, so the most neccesary features have to be:

-   **File Path Validation**: To validate that a file path argument is correct.
-   **File reading**: A file reader to read their text content.
-   **Word Count**: To count the number of words from the file content.

### Functionalities Not Implemented (YAGNI)

-   **Multiple language support**: The program only counts words based on common English separators. Handling multiple languages ​​and their peculiarities isn't necessary in this phase.
-   **Statistical analysis**: Features such as counting the frequency of each word or another one aren't necessary for the basic word counting task.
-   **Support for multiple file formats**: The program only reads text files (.txt), but other formats such as PDF, DOCX, etc. isn't required for now.

## Use

1. You have to create a txt file at the same height as the `Program.cs` file. The name of the name have to be `text.txt`.
2. Run the program using this command from DesignPrinciples directory:

```bash
dotnet run --project Yagni/Yagni.csproj Yagni/text.txt
```

You have to see this result:

```bash
➜ dotnet run --project Yagni/Yagni.csproj Yagni/text.txt
The file contains 7 words.
```