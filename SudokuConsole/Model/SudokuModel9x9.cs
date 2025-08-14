namespace SudokuConsole.Model;

internal class SudokuModel9x9 : ISudokuModel
{
    public short MaxSize => 9;

    private readonly Cell[,] _values;
    public char this[int row, int column] 
    {
        get
        {
            if (_values[row, column] is not null)
            {
                return _values[row, column].Value;
            }
            else
            {
                return '\0';
            }
        }
        set
        {
            Cell cell = new(value, true);
            _values[row, column] = cell;
        }
    }

    public SudokuModel9x9()
    {
        _values = new Cell[MaxSize, MaxSize];
    }
}
