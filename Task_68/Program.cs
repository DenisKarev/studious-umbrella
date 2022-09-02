// Задача 68: Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3 n = 2 -> A(m,n) = 29
//
// m == 0          ->> n + 1
// n == 0 & m > 0  ->> A(m - 1, 1)
// m > 0 & n > 0   ->> A(m - 1, A(m, n - 1))

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

int AkkermanFun(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0 && m > 0) return AkkermanFun(m - 1, 1);
    return AkkermanFun(m - 1, AkkermanFun(m, n - 1));
}

// int a = 3, b = 2;
// Console.WriteLine($"{AkkermanFun(a, b)}");
int[,] arr = new int[6, 4];

for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 6; j++)
    {
        arr[j, i] = AkkermanFun(i, j);
    }
}
PrintMatrix(arr);
Console.WriteLine($"{AkkermanFun(4, 0)}");
// Console.WriteLine($"{AkkermanFun(4, 1)}"); // Stack overflow.
// Console.WriteLine($"{AkkermanFun(5, 0)}"); // Stack overflow.