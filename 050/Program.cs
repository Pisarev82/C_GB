// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет

int[,] CreateMatrixRndInt(int row, int col, int min, int max) 
{
    
    int[,] matrix = new int[row, col];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
} 

void PrintMatrix(int[,] matrix) 
{
    for (int i = 0; i <  matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            if (j < matrix.GetLength(1) -1) Console.Write($"{matrix[i, j], 3}, ");
            else Console.Write($"{matrix[i, j], 3} ");
        }
        Console.WriteLine("]");
    }
        
}

int InputInt (string textForUser)
{
    Console.Write(textForUser);
    return  Convert.ToInt32(Console.ReadLine()); 
}

void PrintValueByIndex (int[,] matrix, int row, int col)
{
    bool correctIndex = (  row <= matrix.GetLength(0) 
                        && col <= matrix.GetLength(1)
                        && row > 0
                        && col > 0
                        );
    if (correctIndex) Console.WriteLine($"В элементе с индексом [{row}, {col}] хранится значение {matrix[row-1,col-1]}");
    else Console.WriteLine($"Элемент с индексом [{row}, {col}] в массиве отсутствует.");
}

int line = InputInt("Введити номер строки: ");
int column = InputInt("Введити номер столбца: ");

int[,] arrey2D =  CreateMatrixRndInt(3, 7, 0, 10); 
PrintValueByIndex(arrey2D, line, column);
Console.WriteLine("печатаю массив для проверки:");
PrintMatrix(arrey2D);