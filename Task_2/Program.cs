// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
// 
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.WriteLine("Enter number A");                 // вариант ввода с консоли
// int numA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter number B");
// int numB = Convert.ToInt32(Console.ReadLine());

int numA = 17, numB = 15;
int max = -1;

Console.Write($"Из чисел {numA} и {numB}, большее(max): ");

// if (numA>numB) Console.WriteLine(numA);              // Вариант 1
// else Console.WriteLine(numB);

// if (numA > numB) max = numA;                         // Вариант 2
// else max = numB;
// Console.WriteLine(max);

max = numA > numB ? numA : numB;                        // Вариант 3 (после второго семинара
Console.WriteLine(max);                                 // пробую тернарные операции)