using SudokuConsole.Model;
using System.Text;

namespace SudokuConsole.View;

internal class View9x9 : ISudokuView
{
    private readonly string _canva = """
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
            """;
    public View9x9()
    {
        StringBuilder stringBuilder = new();
        int i = 0;
        foreach (char c in _canva)
        {
            stringBuilder.Append(c == '.' ? $"{{{i++}}}" : c);
        }
        _canva = stringBuilder.ToString();
    }

    public void Display(ISudokuModel model)
    {
        int index = 0;
        object[] values = new object[model.MaxSize * model.MaxSize];
        for (int row = 0; row < model.MaxSize; row++)
        {
            for (int column = 0; column < model.MaxSize; column++)
            {
                char c = model[row, column];
                values[index] = c != ISudokuModel.EMPTY ? c : " ";
                index++;
            }
        }

        Console.WriteLine(string.Format(_canva, values));
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
