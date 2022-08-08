// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100); // [10, 100) = 10...99
Console.WriteLine($"Random number in range 10...99 => {number}");

int firstDigit = number / 10;
int secondDigit = number % 10;

if (firstDigit == secondDigit) Console.WriteLine("digit are equal");
else
{
    // int max = firstDigit;
    // if (secondDigit > max) max = secondDigit;
    int max = firstDigit > secondDigit ? firstDigit : secondDigit; // тернарное выражение??
    // Console.WriteLine($"Max digit in number is > {max}");   
    Console.Write("Max digit in number is > ");
    Console.WriteLine(firstDigit > secondDigit ? firstDigit : secondDigit);
}

int MaxDigit(int num) // Сигнатура метода??
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    if (firstDigit == secondDigit) return -1;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

int anNumber = new Random().Next(10, 100);

int maxDigit = MaxDigit(anNumber);
// Console.WriteLine($"Max digit in number {anNumber} > {maxDigit}");

string result = maxDigit != -1 ? maxDigit.ToString () : "digit are equal";
Console.WriteLine($"Max digit in number {anNumber} > {result}");
