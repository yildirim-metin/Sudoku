using SudokuConsole.Model;
using SudokuConsole.View;

namespace SudokuConsole.Contoller;

internal class SudokuController
{
    public ISudokuView View { get; set; }
    public ISudokuModel Model { get; set; }

    public SudokuController(ISudokuModel model, ISudokuView view)
    {
        Model = model;
        View = view;
    }

    public void Start()
    {
        View.DisplayEmptyGrid();

        Console.WriteLine("Entrer la ligne: ");
        string? row = Console.ReadLine();

        Console.WriteLine("Entrer la colonne: ");
        string? column = Console.ReadLine();

        Console.WriteLine("Entre la valeur: ");
        string? value = Console.ReadLine();

        Model[row, column] = value;

        View.Display(Model!);
    }
}
