// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int CounNumbers (int integer)
{
    int i = 0;
    while (integer > 0)
    {
        i++;
        integer /= 10;
    }
    return i;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int increm = 0;
int tempI = CounNumbers(num);

// for (increm = 0; tempI > 0; tempI /= 10)
// for (; tempI > 0; tempI /= 10)
// {
//     increm ++;
// }

// Console.Write($"Вчисле {num} {increm} цифры");
Console.Write($"Вчисле {num} {tempI} цифры");