using SudokuConsole.Model;
using SudokuConsole.View;

namespace SudokuConsole.Contoller;

internal class SudokuController
{
    public ISudokuView? View { get; set; }
    public ISudokuModel? Model { get; set; }

    public void Start()
    {
        if (View is not null && Model is not null)
        {
            View.DisplayEmptyGrid();
            Model.AddValue(2, 3, '4');
            Model.AddValue(1, 3, '2');
            Model.AddValue(1, 1, '1');
            Model.AddValue(3, 3, '9');
            View.Display(Model!);
        }
    }
}
