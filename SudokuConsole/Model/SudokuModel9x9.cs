namespace SudokuConsole.Model;

internal class SudokuModel9x9 : SudokuModel
{
    public override short MaxSize => 9;

    public SudokuModel9x9() : base()
    {
    }

    public override bool IsValid(int row, int column)
    {
        bool isRowOutOfBand = row < 0 || row >= MaxSize;
        bool isColumnOutOfBand = column < 0 || column >= MaxSize;

        return !isRowOutOfBand && !isColumnOutOfBand;
    }

    public override bool IsValueValid(char value)
    {
        char[] validValues = ['1', '2', '3', '4', '5', '6', '7', '8', '9'];
        return validValues.Contains(value);
    }
}
