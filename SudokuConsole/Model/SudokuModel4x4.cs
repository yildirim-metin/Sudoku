namespace SudokuConsole.Model;

internal class SudokuModel4x4 : ISudokuModel
{
    public short MaxSize => 4;

    private readonly char[,] _values;

    public char this[int row, int column]
    {
        get => _values[row, column];
        set => _values[row, column] = value;
    }

    public SudokuModel4x4()
    {
        _values = new char[MaxSize, MaxSize];
    }

    public void AddValue(int row, int column, char value)
    {
        this[row, column] = value;
    }

    public char GetValue(int row, int column)
    {
        return this[row, column];
    }
}
