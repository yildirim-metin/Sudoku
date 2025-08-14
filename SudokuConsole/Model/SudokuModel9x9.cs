namespace SudokuConsole.Model;

internal class SudokuModel9x9 : ISudokuModel
{
    public short MaxSize => 9;

    private readonly char[,] _values;
    public char this[int row, int column] 
    {
        get => _values[row, column];
        set => _values[row, column] = value;
    }

    public SudokuModel9x9()
    {
        _values = new char[MaxSize, MaxSize];
    }
}
