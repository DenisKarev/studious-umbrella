// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

int[,] CreateMatrixRndInt(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)       // or i < row
    {
        for (int j = 0; j < matrix.GetLength(1); j++)   // or i < col
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3},");
            else Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine("]");
    }

}

int[] FindFirstMinElementIndexes(int[,] matrix)
{
    int[] resu = new int[2];
    int min = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                resu[0] = i; resu[1] = j;
            }
        }
    }
    return resu;
}

int[,] DeleteRowColByIndexes(int[,] matrix, int[] indexes)
{
    int[,] result = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int rowM = matrix.GetLength(0), colM = matrix.GetLength(1);
    int row = 0, col = 0;
    while (row < indexes[0])
    {
        while (col < indexes[1])
        {
            result[row, col] = matrix[row, col];
            col++;
        }
        row++;
    }
    return result;
}

int[,] matr = new int[,] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 }, { 5, 2, 6, 7 }, };

// int[,] matr = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(matr);
Console.WriteLine();


int[] coords = FindFirstMinElementIndexes(matr);
Console.Write(coords[0]);
Console.Write(coords[1]);
Console.WriteLine();
int[,] trimmedMatr = DeleteRowColByIndexes(matr, coords);
PrintMatrix(trimmedMatr);
