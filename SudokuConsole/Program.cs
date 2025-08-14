using SudokuConsole.Contoller;
using SudokuConsole.Model;
using SudokuConsole.View;

Console.WriteLine("""
    Menu
    1. 4x4
    2. 9x9
    3. Samourai
    """);

Console.Write("Quel sudoku tu souhaite jouer ? :");
string? game = Console.ReadLine();

bool isNumber = int.TryParse(game, out int gameChoice);
while (!isNumber)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Saisie invalide !");
    Console.ForegroundColor = ConsoleColor.Gray;

    Console.Write("Quel sudoku tu souhaite jouer ? :");

    game = Console.ReadLine();
    isNumber = int.TryParse(game, out gameChoice);
}

while (isNumber && (gameChoice < 0 || gameChoice > 3))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Choisis une valeur entre 1 et 3 !");
    Console.ForegroundColor = ConsoleColor.Gray;

    Console.Write("Quel sudoku tu souhaite jouer ? :");

    game = Console.ReadLine();
    isNumber = int.TryParse(game, out gameChoice);
}

switch(game)
{
    case "1":
        SudokuController sudokuController = new()
        {
            View = new View4x4(),
            Model = new SudokuModel4x4()
        };

        sudokuController.Start();
        break;

    case "2":
        sudokuController = new()
        {
            View = new View9x9(),
            Model = new SudokuModel9x9()
        };
        sudokuController.Start();

        break;

    case "3":
        Console.WriteLine("Pas encore implémenter");
        break;

    default:
        break;
}

//sudokuController.View = new ViewSamourai();
//sudokuController.Model = new SudokuModelSamourai();
//sudokuController.Start();