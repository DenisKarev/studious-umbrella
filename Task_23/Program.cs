// Задача 23 Напишите программу, которая принимает на вход
// число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.Write("Введите степень в которую будем возводить числа: ");
// int power = Convert.ToInt32(Console.ReadLine());

int power = 3;  // power number
Console.Write("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 1)
{
    int i = 1;
    Console.WriteLine($"Число {num} !");
    while (i <= num)
    {
        Console.WriteLine($"{i} - {Math.Pow(i, power)} ");
        i++;
    }
}
else if  (num <= -1)
{
    int i = 1;
    Console.WriteLine($"Число {num} !");
    while (i >= num)
    {
        Console.WriteLine($"{i} - {Math.Pow(i, power)} ");
        i--;
    }
}
else Console.WriteLine("Число не соотвествует условию");