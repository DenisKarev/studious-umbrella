// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"


void NaturalIntegersM2N(int valueM, int valueN)
{
    int increm = 0;
    if (valueM > valueN)
    {
        increm = -1;
    }
    else increm = 1;
    if (valueM == valueN)
    {
        Console.Write($"{valueN} ");
        return;
    }
    NaturalIntegersM2N(valueM, valueN - increm);        // 5 4 3 2 1 
    Console.Write($"{valueN} ");
}

Console.WriteLine("Enter positive integer M:");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter positive integer N:");
int numberN = Convert.ToInt32(Console.ReadLine());

Console.Write($"M = {numberM}; N = {numberN} -> \" ");
NaturalIntegersM2N(numberM, numberN);
Console.Write("\"");