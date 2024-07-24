# GUESSING NUMBER GAME

It applies the KISS (Keep It Simple, Stupid) principle by maintaining a simple design and logic. Some reasons for that are the structure, the names for classes, atributter, methods, single responsability, and there aren't duplicate code.

## Application of the KISS Principle

1. The classes like `NumberDisplayer` `NumberGenerator` `NumberValidator` `UserInputHandler` and `GuessingNumberGame` are doing what their names say, means prevent confusion for the user or programmer.

2. Avoiding overly complex modularization: Dividing the program into too many small modules or classes can break down the principle, because we are adding unncessary complexity, for example using MVC for the small game can increase the complexity, but just using utils classes the logic and their structure is more simple to understand.

3. Unnecessary design patterns: The game doesn't need unncesarry layers of abstraction for the simple logic of the game.

## Use

Run the program using this command from DesignPrinciples directory:

```bash
dotnet run --project Kiss/Kiss.csproj
```

You have to see this result:

```bash
➜ dotnet run --project Kiss/Kiss.csproj

I'm thinking of a number between 0 and 100.
Try to guess.

Enter your guess number: 50
The number should be smaller.

Enter your guess number: 25
The number should be smaller.

Enter your guess number: 15
The number should be greater.

Enter your guess number: 20
The number should be smaller.

Enter your guess number: 17
The number should be greater.

Enter your guess number: 19
The number should be smaller.

Enter your guess number: 18
You guessed the number!

```
