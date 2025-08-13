using SudokuConsole.Contoller;
using SudokuConsole.View;

SudokuController sudokuController;

View4x4 view4 = new();
sudokuController = new(view4);
sudokuController.Start();

View9x9 view9 = new();
sudokuController.View = view9;
sudokuController.Start();

ViewSamourai viewSamourai = new();
sudokuController.View = viewSamourai;
sudokuController.Start();