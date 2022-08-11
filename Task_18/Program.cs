// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите четверть:");
int quart = Convert.ToInt32(Console.ReadLine());

Console.Write("Четверть {0} ", quart);

string GetQuarterRangeXY(int q1)      // можно без else потому-что return -> выход из метода!
{
    if (q1 == 1) return "Значения X > 0 и Y > 0";
    if (q1 == 2) return "Значения X < 0 и Y > 0";
    if (q1 == 3) return "Значения X < 0 и Y < 0";
    if (q1 == 4) return "Значения X > 0 и Y < 0";
    return "Указана некорректная четверь";
}

string qr = GetQuarterRangeXY(quart);
Console.WriteLine(qr);