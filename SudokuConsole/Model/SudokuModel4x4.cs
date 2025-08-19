namespace SudokuConsole.Model;

internal class SudokuModel4x4 : SudokuModel
{
    public override short MaxSize => 4;

    public SudokuModel4x4() : base()
    {
    }

    public override bool IsValid(int row, int column)
    {
        bool isRowOutOfBand = row < 0 || row >= MaxSize;
        bool isColumnOutOfBand = column < 0 || column >= MaxSize;
        
        if (isRowOutOfBand || isColumnOutOfBand)
        {
            return false;
        }
        else
        {
            bool isCellLocked = _values is not null && _values[row, column].IsLock;
            return !isCellLocked;
        }
    }
}
