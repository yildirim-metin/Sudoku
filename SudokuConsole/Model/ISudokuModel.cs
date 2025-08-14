namespace SudokuConsole.Model;

internal interface ISudokuModel
{
    short MaxSize { get; }
    
    char this[int row, int column] { get; set; }
}
