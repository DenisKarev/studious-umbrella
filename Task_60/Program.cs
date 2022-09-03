// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] CreateMatrix3DRndInt(int row, int col, int dep, int min, int max)
{
    int[,,] matrix = new int[row, col, dep];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)       // or i < row
    {
        for (int j = 0; j < matrix.GetLength(1); j++)   // or i < col
        {
            for (int k = 0; k < matrix.GetLength(2); k++)   // or k < dep (depth)
            {
                int tempR = rnd.Next(min, max + 1);
                while (CheckIntInMatrix3D(matrix, tempR))
                {
                    tempR = rnd.Next(min, max + 1);
                }
                matrix[i, j, k] = tempR;
            }
        }
    }
    return matrix;
}

void PrintMatrix3D(int[,,] matrix)
{Console.WriteLine();
    for (int k = 0; k < matrix.GetLength(2); k++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j < matrix.GetLength(1) - 1)
                    Console.Write($"{matrix[i, j, k],4}({i},{j},{k})");
                else Console.Write($"{matrix[i, j, k],4}({i},{j},{k})");
            }
            Console.WriteLine();
        }
        // Console.WriteLine();
    }
}

bool CheckIntInMatrix3D(int[,,] matrix, int value)
{
    int row = matrix.GetLength(0);
    int col = matrix.GetLength(1);
    int dep = matrix.GetLength(2);
    bool res = false;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            for (int k = 0; k < dep; k++)
            {
                if (matrix[i, j, k] == value){
                    res = true; Console.Write(".");
                    break;
                }
            }
        }
    }
    return res;
}

int[,,] matr3D = CreateMatrix3DRndInt(3, 3, 3, 10, 40);

PrintMatrix3D(matr3D);