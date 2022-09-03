// Задача 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

// bool CheckMatrixesMultipliable(int[,] matrixA, int[,] matrixB)
// {
//     if (matrixA.GetLength(1) == matrixB.GetLength(0)) return true;
//     else return false;
// }

int[,] MultiplyMatrixes(int[,] matrixA, int[,] matrixB)
{
    int rowRes = matrixA.GetLength(0);
    int colRes = matrixB.GetLength(1);

    int multip = matrixA.GetLength(1);

    int[,] resMatrix = new int[rowRes, colRes];
    for (int i = 0; i < rowRes; i++)
    {
        for (int j = 0; j < colRes; j++)
        {
            for (int k = 0; k < multip; k++)
            {
                resMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    return resMatrix;
}

// Матрицы из примера для проверок
int[,] matr1 = new int[,]{  {2, 4},
                            {3, 2}, };
int[,] matr2 = new int[,]{  {3, 4},
                            {3, 3}, };

// int[,] matr1 = new int[,]{  {2, 4, 2},
//                             {3, 2, 2}, };
// int[,] matr2 = new int[,]{  {3, 4},
//                             {3, 3},
//                             {2, 2} };

// int[,] matr1 = new int[,]{  {2, 4,},
//                             {3, 2,},
//                             {2, 2,}, };
// int[,] matr2 = new int[,]{  {3, 4, 2},
//                             {3, 3, 2},};

// Генерация случайных матриц для проверки
// int[,] matr1 = CreateMatrixRndInt(2, 4, 1, 9);
// int[,] matr2 = CreateMatrixRndInt(4, 2, 1, 9);

PrintMatrix(matr1);
Console.WriteLine();
PrintMatrix(matr2);
Console.WriteLine();
if (matr1.GetLength(1) == matr2.GetLength(0))
{
    int[,] matr3 = MultiplyMatrixes(matr1, matr2);
    PrintMatrix(matr3);
}
else Console.WriteLine("Матрицы невозможно перемножить");
