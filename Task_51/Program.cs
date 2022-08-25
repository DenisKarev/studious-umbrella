// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.

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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],2},");
            else Console.Write($"{matrix[i, j],2}");
        }
        Console.WriteLine("]");
    }

}

int CalculateMatrix(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j) sum += matrix[i, j];
        }
    }
    return sum;
}

int CalculateMatrix2(int[,] matrix)
{
    int sum = 0;
    int size = matrix.GetLength(0);
    if (matrix.GetLength(0) > matrix.GetLength(1)) size = matrix.GetLength(1);
    for (int i = 0; i < size; i++)
    {
        int j = i;
        sum += matrix[i, j];
    }
    return sum;
}
int[,] mat = CreateMatrixRndInt(3, 8, 0, 9);
PrintMatrix(mat);
int summm = CalculateMatrix2(mat);
Console.WriteLine(summm);