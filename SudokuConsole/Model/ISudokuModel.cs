namespace SudokuConsole.Model;

internal interface ISudokuModel
{
    const char EMPTY = '\0';
    short MaxSize { get; }
    
    char this[int row, int column] { get; set; }
}
