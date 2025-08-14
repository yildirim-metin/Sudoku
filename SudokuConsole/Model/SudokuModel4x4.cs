namespace SudokuConsole.Model;

internal class SudokuModel4x4 : ISudokuModel
{
    public short MaxSize => 4;

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
                return ISudokuModel.EMPTY;
            }
        }
        set
        {
            Cell cell = new(value, true);
            _values[row, column] = cell;
        }
    }

    public SudokuModel4x4()
    {
        _values = new Cell[MaxSize, MaxSize];
        for (int i = 0; i < MaxSize; i++)
        {
            for (int j = 0; j < MaxSize; j++)
            {
                _values[i, j] = new Cell();
            }
        }
    }
}
