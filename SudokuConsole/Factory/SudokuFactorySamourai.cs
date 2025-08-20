using SudokuConsole.Model;
using SudokuConsole.View;

namespace SudokuConsole.Factory;

internal class SudokuFactorySamourai : SudokuFactory
{
    protected override ISudokuModel CreateModel()
    {
        return new SudokuModelSamourai();
    }

    protected override ISudokuView CreateView()
    {
        return new ViewSamourai();
    }
}
