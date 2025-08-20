using SudokuConsole.Common.Exception;

namespace SudokuConsole.Model;

internal class Cell
{
    private char _value;

    public char Value
    {
        get => _value;
        set
        {
            if (IsLocked)
            {
                throw new CellLockException();
            }
            else
            {
                _value = value;
            }
        }
    }
    public bool IsLocked
    {
        get;
        set;
    }

    public Cell() : this(ISudokuModel.EMPTY)
    {
    }

    public Cell(char value, bool isLock = false)
    {
        Value = value;
        IsLocked = isLock;
    }
}
