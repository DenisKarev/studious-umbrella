// Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).
//
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите число:");
int numb = Convert.ToInt32(Console.ReadLine());

int resu = numb % 2;

if (resu == 0) Console.WriteLine($"Число: {numb} четное");
else Console.WriteLine($"Число: {numb} не четное");

// Console.WriteLine(resu == 0 ? $"Число: {numb} четное" : $"Число: {numb} не четное");
// Console.WriteLine(numb % 2 == 0 ? $"Число: {numb} четное" : $"Число: {numb} не четное");