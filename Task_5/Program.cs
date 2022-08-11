// Задача 5: Напишите программу, которая на вход принимает одно число (N),
//  а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

// int number = Convert.ToInt32 (Console.ReadLine());       // Ввод с консоли

int number = 0;
if (number == 0) Console.WriteLine("0");
else
{
    if (number < 0)
    {
        int i = number;
        for (; i < -number; i++)
        {
            Console.Write($"{i}, ");
        }
    }
    else
    {
        int i = -number;
        for (; i < number; i++)
        {
            Console.Write($"{i}, ");
        }
    }
}
