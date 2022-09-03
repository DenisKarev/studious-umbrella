// Задача 54: Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void SortAllMatrixRowsFromHigh(int[,] matrix)
{
    int row = matrix.GetLength(0);
    int col = matrix.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            int iMax = j;
            for (int k = j + 1; k < col; k++)
            {
                if (matrix[i, k] > matrix[i, iMax]) iMax = k;
            }
            int temp = matrix[i, j];
            matrix[i, j] = matrix[i, iMax];
            matrix[i, iMax] = temp;
        }
    }
}

// Матрица из примера для проверок
// int[,] matr = new int[,]{   {1, 4, 7, 2},
//                             {5, 9, 2, 3},
//                             {8, 4, 2, 4},   };

int[,] matr = CreateMatrixRndInt(4, 8, 0, 9);

PrintMatrix(matr);
Console.WriteLine();

SortAllMatrixRowsFromHigh(matr);
PrintMatrix(matr);