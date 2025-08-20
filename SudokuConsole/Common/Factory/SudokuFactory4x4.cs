using SudokuConsole.Model;
using SudokuConsole.View;

namespace SudokuConsole.Common.Factory;

internal class SudokuFactory4x4 : SudokuFactory
{
    protected override ISudokuModel CreateModel()
    {
        return new SudokuModel4x4();
    }

    protected override ISudokuView CreateView()
    {
        return new View4x4();
    }
}
