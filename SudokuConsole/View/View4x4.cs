using SudokuConsole.Model;
using System.Text;

namespace SudokuConsole.View;

internal class View4x4 : ISudokuView
{
    public string Value = """
        +-----+-----+
        | . . | . . |
        | . . | . . |
        +-----+-----+
        | . . | . . |
        | . . | . . |
        +-----+-----+
        """;

    public View4x4()
    {
        StringBuilder stringBuilder = new();
        int i = 0;
        foreach (char c in Value)
        {
            stringBuilder.Append(c == '.' ? $"{{{i++}}}" : c);
        }
        Value = stringBuilder.ToString();
    }

    public void Display(ISudokuModel model)
    {
        int cpt = 0;
        string[] stringTab = new string[4*4];
        for (int row = 0; row < 4; row++)
        {
            for (int column = 0; column < 4; column++)
            {
                var c = char.ToString(model.GetValue(row + 1, column + 1));
                stringTab[cpt] = c != "\0" ? c : " ";
                cpt++;
            }
        }

        Console.WriteLine(string.Format(Value, stringTab));
    }

    public void DisplayEmptyGrid()
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
