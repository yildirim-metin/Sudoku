namespace SudokuConsole.Model;

internal interface ISudokuModel
{
    void AddValue(int row, int column, char value);
    char GetValue(int row, int column);
}
