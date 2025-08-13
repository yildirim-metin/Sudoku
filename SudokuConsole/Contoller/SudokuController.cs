using SudokuConsole.View;

namespace SudokuConsole.Contoller;

internal class SudokuController
{
    public ISudokuView View { get; set; }

    public SudokuController(ISudokuView view)
    {
        View = view;
    }

    public void Start()
    {
        View.Display();
    }
}
