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
    int rowM = matrix.GetLength(0), colM = matrix.GetLength(1);
    int[,] result = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int crossed = 0;
    for (int i = 0; i < indexes[0]; i++)
    {
        for (int j = 0; j < indexes[1]; j++)
        {
            result[i, j] = matrix[i, j];
        }
    }
    crossed = 1;
    for (int i = 0; i < indexes[0]; i++)
    {
        for (int j = indexes[1] + crossed; j < colM; j++)
        {
            result[i, j - crossed] = matrix[i, j];
        }
    }    
    for (int i = indexes[0] + crossed; i < rowM; i++)
    {
        for (int j = 0; j < indexes[1]; j++)
        {
            result[i - crossed, j] = matrix[i, j];
        }
    }    
    for (int i = indexes[0] + crossed; i < rowM; i++)
    {
        for (int j = indexes[1] + crossed; j < colM; j++)
        {
            result[i-crossed, j-crossed] = matrix[i, j];
        }
    }
    return result;
}

// int[,] matr = new int[,] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 }, { 5, 2, 6, 7 }, };

// int[,] matr = new int[,] {
//      { 5, 4, 7, 4 },
//      { 5, 9, 2, 3 },
//      { 8, 4, 2, 4 },
//      { 5, 2, 6, 7 }, };

int[,] matr = CreateMatrixRndInt(4, 5, 1, 9);
PrintMatrix(matr);
Console.WriteLine();


int[] coords = FindFirstMinElementIndexes(matr);
Console.Write(coords[0]);
Console.Write(coords[1]);
Console.WriteLine();
int[,] trimmedMatr = DeleteRowColByIndexes(matr, coords);
PrintMatrix(trimmedMatr);
