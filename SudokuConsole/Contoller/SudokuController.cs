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
            Model[2, 3] = '4';
            Model[1, 3] = '2';
            Model[1, 1] = '1';
            Model[3, 3] = '9';
            if (Model is SudokuModel9x9) Model[8, 8] = '9';
            View.Display(Model!);
        }
    }
}
