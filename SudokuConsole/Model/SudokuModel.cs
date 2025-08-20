using SudokuConsole.Common.Exception;

namespace SudokuConsole.Model;

internal abstract class SudokuModel : ISudokuModel
{
    public abstract short MaxSize { get; }

    protected Cell[,]? _values;
    public char this[int row, int column]
    {
        get
        {
            if (_values is not null && _values[row, column] is not null)
            {
                return _values[row, column].Value;
            }
            else
            {
                return ISudokuModel.EMPTY;
            }
        }
        set
        {
            if (IsValid(row, column))
            {
                if (IsValueValid(value))
                {
                    Cell cell = new(value, true);
                    _values![row, column] = cell;
                }
                else
                {
                    throw new ValueSudokuException();
                }
            }
            else
            {
                throw new PositionSudokuException();
            }
        }
    }
    
    protected SudokuModel()
    {
        Init();
    }

    public virtual void Init()
    {
        _values = new Cell[MaxSize, MaxSize];
        for (int i = 0; i < MaxSize; i++)
        {
            for (int j = 0; j < MaxSize; j++)
            {
                _values[i, j] = new Cell();
            }
        }
    }

    public abstract bool IsValid(int row, int column);
    public abstract bool IsValueValid(char value);
}
