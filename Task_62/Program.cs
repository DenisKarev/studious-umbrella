// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int FillSquareMatrixOneCircle(int[,] matrixIn, int origin, int workR, int workC, int cou, int circ)
{
    // right
    for (int j = workR; j < matrixIn.GetLength(1) - origin; j++)
    {
        matrixIn[workR, j] = cou++;
    }
    // down
    workC = matrixIn.GetLength(1) - circ;
    workR++;
    for (int i = workR; i < matrixIn.GetLength(0) - origin; i++)
    {
        matrixIn[i, workC] = cou++;
    }
    // left
    workC--;
    workR = matrixIn.GetLength(0) - circ;
    for (int j = workC; j >= origin; j--)
    {
        matrixIn[workR, j] = cou++;
    }
    // up
    workC = origin;
    workR--;
    for (int i = workR; i > origin; i--)
    {
        matrixIn[i, workC] = cou++;
    }
    return cou;
}

void FillSquareMatrixSpiral(int[,] matrix)
{
    int i = 0;
    int count = 1;
    int start = 0;
    int circle = 1;
    int working_row = 0;
    int working_col = 0;
    while (i < matrix.GetLength(0) / 2)
    {
        count = FillSquareMatrixOneCircle(matrix, start, working_row, working_col, count, circle);
        start++;
        circle++;
        working_row++;
        working_col++;
        i++;
    }
    if (matrix.GetLength(0) % 2 == 1) matrix[working_row,working_col] = count;
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

int[,] matr = new int[4, 4];
FillSquareMatrixSpiral(matr);

PrintMatrix(matr);