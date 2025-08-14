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
}
