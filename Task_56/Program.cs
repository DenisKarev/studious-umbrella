// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер
// строки с наименьшей суммой элементов: 1 строка

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

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write(array[array.Length - 1]);
    Console.WriteLine("]");
}

void PrintMatrixWithRowSums(int[,] matrix, int[] sums)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write($"[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3},");
            else Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine($"] [{sums[i],3}]");
    }

}

int[] FindMinimalSumRow(int[,] matrix)
{
    int[] resultM = new int[matrix.GetLength(0)];
    int row = matrix.GetLength(0);
    int col = matrix.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            resultM[i] += matrix[i, j];
        }
    }
    return resultM;
}

int FindMinimalRow(int[] array)
{
    int iMin = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < array[iMin]) iMin = i;
    }
    return iMin;
}

// Матрица из примера для проверок
// int[,] matr = new int[,]{   {1, 4, 7, 2},
//                             {5, 9, 2, 3},
//                             {8, 4, 2, 4},
//                             {5, 2, 6, 7},   };

int[,] matr = CreateMatrixRndInt(4, 5, 0, 9);
int[] resMatr = FindMinimalSumRow(matr);
PrintMatrixWithRowSums(matr, resMatr);
Console.WriteLine();
Console.WriteLine($"{FindMinimalRow(resMatr) + 1} cтрока имеет минимальную сумму элементов");