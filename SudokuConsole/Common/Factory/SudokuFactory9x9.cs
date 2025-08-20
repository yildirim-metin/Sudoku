using SudokuConsole.Model;
using SudokuConsole.View;

namespace SudokuConsole.Common.Factory;

internal class SudokuFactory9x9 : SudokuFactory
{
    protected override ISudokuModel CreateModel()
    {
        return new SudokuModel9x9();
    }

    protected override ISudokuView CreateView()
    {
        return new View9x9();
    }
}
