namespace SudokuConsole.Model;

internal class SudokuModel9x9 : ISudokuModel
{
    const int MAX_SIZE = 9;

    private readonly char[,] _values = new char[MAX_SIZE, MAX_SIZE];

    public void AddValue(int row, int column, char value)
    {
        _values[row - 1, column - 1] = value;
    }

    public char GetValue(int row, int column)
    {
        return _values[row - 1, column - 1];
    }
}
