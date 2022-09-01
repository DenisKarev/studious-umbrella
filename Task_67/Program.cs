// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int SumNumberDigitals(int value)
{
    // int summ = 0;
    // if (value <= 10) return summ += value % 10;
    // summ += SumNumberDigitals(value / 10);
    // return summ += value % 10;
    int summ = value % 10;
    if (value > 0) summ += SumNumberDigitals(value / 10);
    return summ;
}

Console.WriteLine("Enter positive integer N:");
int numberN = Convert.ToInt32(Console.ReadLine());

int summa = SumNumberDigitals(numberN);
Console.WriteLine(summa);