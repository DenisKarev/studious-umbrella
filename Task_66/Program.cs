// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int IntegersSumFromM2N(int m, int n)
{
    if (m == n) return m;
    else return m + IntegersSumFromM2N(m + 1, n);
}

Console.WriteLine("Enter an integer M:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter an integer N");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine("Fisrt int bigger than second. Counting backwards.");
    Console.WriteLine($"M = {a}; N = {b} -> {IntegersSumFromM2N(b, a)}");
}
else Console.WriteLine($"M = {a}; N = {b} -> {IntegersSumFromM2N(a, b)}");
