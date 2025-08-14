namespace SudokuConsole.Model;

internal interface ISudokuModel
{
    short MaxSize { get; }
    
    char this[int row, int column] { get; set; }

    void AddValue(int row, int column, char value);
    char GetValue(int row, int column);
}
