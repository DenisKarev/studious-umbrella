// Задача 50. Напишите программу, которая на вход принимает позиции
// элемента в двумерном массиве, и возвращает значение этого элемента
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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
void FindInMatrixByIndexes(int[,] matrix, int row, int col)
{
    if (row > matrix.GetLength(0) || col > matrix.GetLength(1))
    Console.WriteLine($"{row}, {col} -> Выход за пределы матрицы!");
    else Console.WriteLine($"{row}, {col} -> {matrix[row-1, col-1]}");
    // Пользователь вводит как видит, а индексы меньше на 1 поэтому row-1 col-1
}

int[,] matr = CreateMatrixRndInt(4, 5, 1, 9);

Console.Write("Введите первый индекс:");
int matrixRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второй индекс:");
int matrixCol = Convert.ToInt32(Console.ReadLine());

PrintMatrix(matr);
FindInMatrixByIndexes(matr, matrixRow, matrixCol);