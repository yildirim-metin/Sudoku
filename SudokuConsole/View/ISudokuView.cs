using SudokuConsole.Model;

namespace SudokuConsole.View;

internal interface ISudokuView
{
    void DisplayEmptyGrid();
    void Display(ISudokuModel model);
}
