namespace SudokuConsole.Common.Exception;

[Serializable]
public class SudokuException : System.Exception
{
	public SudokuException() { }
	public SudokuException(string message) : base(message) { }
	public SudokuException(string message, System.Exception inner) : base(message, inner) { }
}