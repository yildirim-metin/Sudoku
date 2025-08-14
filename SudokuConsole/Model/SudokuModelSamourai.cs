namespace SudokuConsole.Model;

internal class SudokuModelSamourai : ISudokuModel
{
    public short MaxSize => 21 * (21 - 4) * 3 * 6;
    
    private readonly char[,] _values;
    public char this[int row, int column]
    {
        get => _values[row, column];
        set => _values[row, column] = value;
    }

    public SudokuModelSamourai()
    {
        _values = new char[MaxSize, MaxSize];
    }
}
