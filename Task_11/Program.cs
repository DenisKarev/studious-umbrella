// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000); // [100, 1000) = 100...999
// DeleteMiddleDigit
int Digits31inNumber (int num) // методы с большой буквы !!!! 
{
    int firstDigit = number % 10;
    int thirdDigit = number / 100;
    return thirdDigit * 10 + firstDigit;
}

int result = Digits31inNumber (number);
Console.WriteLine($"Random number in range 100...999 => {number} => digits31 in number {result}");