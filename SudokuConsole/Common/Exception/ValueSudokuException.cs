namespace SudokuConsole.Common.Exception;

internal class ValueSudokuException : SudokuException
{
    public ValueSudokuException() : base("Value is not correct") { }
}
