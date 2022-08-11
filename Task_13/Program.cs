// Задача 13: Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.
// Решить без использования строк.
//
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.WriteLine("Веедите число:");                 // Для ввода с консоли
// int numb = Convert.ToInt32 (Console.ReadLine());

int numb = 238793199;
if (numb < 100 && numb > -100) Console.WriteLine("третьей цифры нет");
else
{
    int oper = numb;
    // int ooper = numb;
    while (oper > 1000)
    {
        oper = oper / 10;
    }
    
    // int res = oper / 100;
    Console.WriteLine($"{numb} -> {oper % 10}");
}

// Console.WriteLine(numb < 100 && numb > -100 ? $"третьей цифры нет" : $"{numb} -> {(numb / 100) % 10}");