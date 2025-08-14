namespace SudokuConsole.Model;

internal class SudokuModelSamourai : ISudokuModel
{
    public short MaxSize => 21 * (21 - 4) * 3 * 6;
    
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

    public SudokuModelSamourai()
    {
        _values = new Cell[MaxSize, MaxSize];
    }
}
