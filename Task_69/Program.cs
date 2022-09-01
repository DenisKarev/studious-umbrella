// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

// Console.WriteLine("Enter positive integer A:");
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter positive integer B:");
// int numberB = Convert.ToInt32(Console.ReadLine());

int numberA = 3, numberB = 5;
int res = 0;

int intApowB(int a, int b)  // a4 = a*a3   a3 = a*a2 
{
    if (b == 0) return 1;
    res = a * intApowB(a, b - 1);
    return res;
}

Console.WriteLine(intApowB(numberA, numberB));
