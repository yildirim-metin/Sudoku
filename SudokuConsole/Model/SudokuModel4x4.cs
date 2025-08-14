namespace SudokuConsole.Model;

internal class SudokuModel4x4 : ISudokuModel
{
    public short MaxSize => 4;

    private readonly char[,] _values;

    public SudokuModel4x4()
    {
        _values = new char[MaxSize, MaxSize];
    }

    public void AddValue(int row, int column, char value)
    {
        _values[row, column] = value;
    }

    public char GetValue(int row, int column)
    {
        return _values[row, column];
    }
}
