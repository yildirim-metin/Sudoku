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
        string[] stringTab = new string[model.MaxSize * model.MaxSize];
        for (int row = 0; row < model.MaxSize; row++)
        {
            for (int column = 0; column < model.MaxSize; column++)
            {
                var c = char.ToString(model.GetValue(row, column));
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
