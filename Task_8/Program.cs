// Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
//
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число:");
int numb = Convert.ToInt32(Console.ReadLine());

// int i = 1;
// Console.Write($"{numb} -> ");
// while (i <= numb)
// {
//     Console.Write(i % 2 > 0 ? "" : $"{i}, ");
//     i++;
// }

int i = 2;
Console.Write($"{numb} -> ");
while (i <= numb)
{
    Console.Write($"{i}, ");
    i += 2;
}