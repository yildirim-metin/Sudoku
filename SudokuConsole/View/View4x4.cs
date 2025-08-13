namespace SudokuConsole.View;

internal class View4x4 : ISudokuView
{
    public void Display()
    {
        Console.WriteLine("4x4");
        Console.WriteLine("""
            +-----+-----+
            | . . | . . |
            | . . | . . |
            +-----+-----+
            | . . | . . |
            | . . | . . |
            +-----+-----+
            """);
    }
}
