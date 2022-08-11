// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4


Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 0)
{
    int i = 1;
    Console.WriteLine($"Число {num} !");
    while (i < num)
    {
        Console.WriteLine($"{i} - {Math.Pow(i, 2)}, ");
        i++;
    }
    Console.Write($"{i} - {Math.Pow(i, 2)}.");
}
else Console.WriteLine("Число не соотвествует условию");