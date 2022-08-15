// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int MultNum(int n)
{
    int m = 1;
    for (int i = 1; i <= n; i++) m *= i;
    return m;
}

Console.Write("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());
int mult = MultNum(num);

// for (int i = 1; i <= num; i++)
// {
//     mult  *= i;
// }
Console.WriteLine($"Произведение чисел от 1 до {num} равно: " + mult);
