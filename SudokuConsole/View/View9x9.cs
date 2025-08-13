using SudokuConsole.Model;

namespace SudokuConsole.View;

internal class View9x9 : ISudokuView
{
    public void Display(ISudokuModel model)
    {
        throw new NotImplementedException();
    }

    public void DisplayEmptyGrid()
    {
        Console.WriteLine("9x9");
        Console.WriteLine("""
            +-------+-------+-------+
            | . . . | . . . | . . . |
            | . . . | . . . | . . . |
            | . . . | . . . | . . . |
            +-------+-------+-------+
            | . . . | . . . | . . . |
            | . . . | . . . | . . . |
            | . . . | . . . | . . . |
            +-------+-------+-------+
            | . . . | . . . | . . . |
            | . . . | . . . | . . . |
            | . . . | . . . | . . . |
            +-------+-------+-------+
            """);
    }
}
