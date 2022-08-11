// Задача 4: Напишите программу, которая принимает на вход
// три числа и выдаёт максимальное из этих чисел.
//
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.WriteLine("Enter number A");                 // вариант ввода с консоли
// int numA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter number B");
// int numB = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter number C");
// int numC = Convert.ToInt32(Console.ReadLine());

int numA = 27, numB = 15, numC = 18;
int max = -1;

if (numA > numB)
{
    max = numA;
    if (max < numC) max = numC;
}
else
{
    max = numB;
    if (max < numC) max = numC;
}

// int max = numA > numB ? numA : numB;         // Вариант (после второго семинара
// max = max > numC ? max : numC;               // пробую тернарные операции)

Console.Write($"Из чисел {numA}, {numB} и {numC}, большее(max): {max}");