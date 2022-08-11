// Задача 7: Напишите программу, которая принимает на вход трёхзначное
// число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("Введите трехзначное число:");
int numb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(numb < 100 ? "You must enter 3 digit number" : $"Last digit is: {numb % 10}.");