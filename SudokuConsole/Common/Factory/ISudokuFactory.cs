using SudokuConsole.Contoller;

namespace SudokuConsole.Common.Factory;

internal interface ISudokuFactory
{
    SudokuController CreateController();
}
