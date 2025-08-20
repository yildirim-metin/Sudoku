namespace SudokuConsole.Common.Exception;

internal class PositionSudokuException : SudokuException
{
    public PositionSudokuException() : base("Positions are out of band")
    {
    }
}
