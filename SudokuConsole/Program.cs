using SudokuConsole.Common;
using SudokuConsole.Common.Factory;

Console.WriteLine("""
    Menu
    1. 4x4
    2. 9x9
    3. Samourai
    4. Test binary
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

while (isNumber && (gameChoice < 0 || gameChoice > 4))
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
        SudokuFactory4x4 factory4x4 = new();
        factory4x4.CreateController().Start();
        break;

    case "2":
        SudokuFactory9x9 factory9x9 = new();
        factory9x9.CreateController().Start();
        break;

    case "3":
        //SudokuFactorySamourai factorySamourai = new();
        //factorySamourai.CreateController().Start();
        Console.WriteLine("Pas encore implémenter");
        break;

    case "4":
        Zone z = new();
        Console.WriteLine(z);
        z.Add(7);
        z.Add(8);
        Console.WriteLine(z);
        z.Remove(3);
        Console.WriteLine(z);

        Zone z2 = new(); z2.Add(1); z2.Add(2);
        Console.WriteLine(z2);
        Zone z4 = z.Combine(z2);
        Console.WriteLine(z4);
        Console.WriteLine(z);

        Zone z3 = new(0b1111111111);
        Zone z5 = z2.Combine(z3);
        Console.WriteLine(z5);
        break;

    default:
        break;
}