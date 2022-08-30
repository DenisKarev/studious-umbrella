// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

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

bool CheckMatrixSizes(int[,] matrix)
{
    return matrix.GetLength(0) == matrix.GetLength(1);
}

void SwitchMatrixRowsCols(int[,] matrix)
{
    int temp = 0;
    // int[,] result = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = i + 1; j < matrix.GetLength(1); j++)   // j = i + 1 
        {
            temp = matrix[i, j];             // temp = 1,0
            matrix[i, j] = matrix[j, i];     // 1,0 == 0,1
            matrix[j, i] = temp;             // 0,1 == 1,0
            // result[j,i] = matrix[i,j];
        }
    }
    // return result;
}

// int[,] matr = new int[,] { { 0, 0, 0, 1 }, { 0, 0, 0, 0 }, { 1, 1, 1, 1 }, { 0, 0, 0, 0 }, };

int[,] matr = CreateMatrixRndInt(3, 3, 1, 9);

PrintMatrix(matr);
Console.WriteLine();
if (CheckMatrixSizes(matr))
{
    SwitchMatrixRowsCols(matr);
    PrintMatrix(matr);
}
else Console.WriteLine("Размеры матрицы неравны. невозможна замена строк на столбцы");
