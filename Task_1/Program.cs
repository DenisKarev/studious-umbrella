// 2. Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

Console.Write("Enter int A: ");
int intA = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter int B: ");
int intB = Convert.ToInt32(Console.ReadLine());
int sqrB = intB * intB;
if (intA == sqrB)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}