// Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateMatrixRndDouble(int row, int col, int range)   // 0..100
{
    double[,] matrix = new double[row, col];
    Random rnd = new Random();
    // int range = (max - min) + min;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            matrix[i, j] = rnd.NextDouble() * range;
        }
    }
    return matrix;
}

void PrintMatrixDoubles(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],6:N},");
            else Console.Write($"{matrix[i, j],6:N}");
        }
        Console.WriteLine(" ]");
    }

}


double[,] mat = CreateMatrixRndDouble(4, 8, 100);
PrintMatrixDoubles(mat);