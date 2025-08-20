namespace SudokuConsole.Common.Exception;

internal class CellLockException : SudokuException
{
    public CellLockException() : base("Cell is locked")
    {
    }
}
