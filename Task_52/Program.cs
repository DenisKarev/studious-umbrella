// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void PrintArrayDoubles(double[] array)

{
    Console.Write("[ ");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write("{0:N} | ", array[i]);
    }
    Console.Write("{0:N}", array[array.Length - 1]);
    Console.Write(" ]");
}

double[] AverageArithmeticalInColumns(int[,] matrix)
{
    double[] avArResult = new double[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(1); i++)       // Проходим по столбцам
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            avArResult[i] += matrix[j, i];              // Считаем сумму столбца
        }
        avArResult[i] /= matrix.GetLength(0);           // Считаем среднее арифметическое
    }
    return avArResult;
}

// int[,] matr = {{1, 4, 7, 2},         // Матрица из примера (для проверок)
//                {5, 9, 2, 3},
//                {8, 4, 2, 4}};

int[,] matr = CreateMatrixRndInt(3, 4, 1, 3);
PrintMatrix(matr);

double[] arrAverArithCol = AverageArithmeticalInColumns(matr);

Console.Write("Среднее арифметическое каждого столбца: ");
PrintArrayDoubles(arrAverArithCol);