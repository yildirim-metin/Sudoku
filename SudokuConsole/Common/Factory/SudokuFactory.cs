using SudokuConsole.Contoller;
using SudokuConsole.Model;
using SudokuConsole.View;

namespace SudokuConsole.Common.Factory;

internal abstract class SudokuFactory : ISudokuFactory
{
    public SudokuController CreateController()
    {
        return new SudokuController(CreateModel(), CreateView());
    }

    protected abstract ISudokuModel CreateModel();
    protected abstract ISudokuView CreateView();
}
