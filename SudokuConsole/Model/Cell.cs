namespace SudokuConsole.Model;

internal class Cell
{
    public char Value { get; set; }
    public bool IsLock { get; set; }

    public Cell() : this(ISudokuModel.EMPTY)
    {
    }

    public Cell(char value, bool isLock = false)
    {
        Value = value;
        IsLock = isLock;
    }
}
