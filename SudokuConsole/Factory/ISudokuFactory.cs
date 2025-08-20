using SudokuConsole.Contoller;

namespace SudokuConsole.Factory;

internal interface ISudokuFactory
{
    SudokuController CreateController();
}
