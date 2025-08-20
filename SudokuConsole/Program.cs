using SudokuConsole.Common.Factory;

Dictionary<string, ISudokuFactory> factories = new()
{
    {"4x4", new SudokuFactory4x4() },
    {"9x9", new SudokuFactory9x9() },
    {"Samourai", new SudokuFactorySamourai() },
};

int gameChoice = 0;

while (gameChoice != factories.Count + 1)
{
    DisplayMenu();

    Console.Write("Quel sudoku tu souhaite jouer ? :");
    string? game = Console.ReadLine();

    bool isNumber = IsNumber(ref game, ref gameChoice);
    ValidateGameChoice(factories.Count + 1, ref gameChoice, ref game, ref isNumber);

    if (isNumber && gameChoice != factories.Count + 1)
    {
        Console.Clear();
        ISudokuFactory factory = factories.ElementAt(gameChoice - 1).Value;
        factory.CreateController().Start();
    }
}

void DisplayMenu()
{
    Console.WriteLine("===== Menu =====");
    for (int i = 0; i < factories.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {factories.ElementAt(i).Key}");
    }
    Console.WriteLine($"{factories.Count + 1}. Quitter");
    Console.WriteLine("================");
}

bool IsNumber(ref string? game, ref int gameChoice)
{
    bool isNumber = int.TryParse(game, out gameChoice);
    while (!isNumber)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Saisie invalide !");
        Console.ForegroundColor = ConsoleColor.Gray;

        Console.Write("Quel sudoku tu souhaite jouer ? :");

        game = Console.ReadLine();
        isNumber = int.TryParse(game, out gameChoice);
    }

    return isNumber;
}

void ValidateGameChoice(int maxValue, ref int gameChoice, ref string? game, ref bool isNumber)
{
    while (isNumber && (gameChoice < 0 || gameChoice > maxValue))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Choisis une valeur entre 1 et {factories.Count + 1} !");
        Console.ForegroundColor = ConsoleColor.Gray;

        Console.Write("Quel sudoku tu souhaite jouer ? :");

        game = Console.ReadLine();
        isNumber = int.TryParse(game, out gameChoice);
    }
}