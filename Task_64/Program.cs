// Задача 64: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void NaturalIntegersOne2N(int value)
{
    if (value == 0) return;
    // NaturalIntegersOne2N(value - 1);        // 1 2 3 4 5
    Console.Write($"{value} ");
    NaturalIntegersOne2N(value - 1);        // 5 4 3 2 1 
}

Console.WriteLine("Enter positive integer N:");
int numberN = Convert.ToInt32(Console.ReadLine());

Console.Write($"N = {numberN} -> \" ");
NaturalIntegersOne2N(numberN);
Console.Write("\"");