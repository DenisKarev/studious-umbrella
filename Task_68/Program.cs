// Задача 68: Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3 n = 2 -> A(m,n) = 29
//

// m == 0          ->> n + 1
// n == 0 & m > 0  ->> A(m - 1, 1)
// m > 0 & n > 0   ->> A(m - 1, A(m, n - 1))
int AkkermanFun(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0 && m > 0) return AkkermanFun(m - 1, 1);
    return AkkermanFun(m - 1, AkkermanFun(m, n - 1));
}

int a = 3, b = 2;
Console.WriteLine($"A({a}, {b}) = {AkkermanFun(a, b)}");

// Console.WriteLine($"{AkkermanFun(4, 1)}"); // Stack overflow.
// Console.WriteLine($"{AkkermanFun(5, 0)}"); // Stack overflow.