namespace SudokuConsole.Model;

internal class SudokuModelSamourai : SudokuModel
{
    public override short MaxSize => 21 * (21 - 4) * 3 * 6;

    public SudokuModelSamourai() : base()
    {
    }

    public override void Init()
    {
        throw new NotImplementedException();
    }

    public override bool IsValid(int row, int column)
    {
        throw new NotImplementedException();
    }
}
