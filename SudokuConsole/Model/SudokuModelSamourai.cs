namespace SudokuConsole.Model;

internal class SudokuModelSamourai : ISudokuModel
{
    public char this[int row, int column] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public short MaxSize => throw new NotImplementedException();

    public void AddValue(int row, int column, char value)
    {
        throw new NotImplementedException();
    }

    public char GetValue(int row, int column)
    {
        throw new NotImplementedException();
    }
}
