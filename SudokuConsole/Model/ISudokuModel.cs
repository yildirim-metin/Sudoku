namespace SudokuConsole.Model;

internal interface ISudokuModel
{
    short MaxSize { get; }
    void AddValue(int row, int column, char value);
    char GetValue(int row, int column);
}
