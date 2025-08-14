using SudokuConsole.Contoller;
using SudokuConsole.Model;
using SudokuConsole.View;

SudokuController sudokuController = new();

sudokuController.View = new View4x4();
sudokuController.Model = new SudokuModel4x4();
sudokuController.Start();

sudokuController.View = new View9x9();
sudokuController.Model = new SudokuModel9x9();
sudokuController.Start();

//sudokuController.View = new ViewSamourai();
//sudokuController.Model = new SudokuModelSamourai();
//sudokuController.Start();