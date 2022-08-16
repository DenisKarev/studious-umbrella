// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int NumAPoweredB(int na, int nb)
{
    int tempn = na;
    for (int i = 1; i < nb; i++)
    {
        tempn = tempn * na;
    }
    return tempn;
}

Console.Write("Введите число A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());
// int numAP = NumAPowered (numA, numB);

Console.WriteLine($"Число {numA} в степени {numB}: {NumAPoweredB (numA, numB)}");