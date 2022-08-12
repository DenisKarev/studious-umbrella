// Задача 19
//
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
//
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// int ReverseInt(int n)
// {
//     int ret = 0;
//     while (n>0)
//     {
//         ret = ret*10 + n%10;
//         n /=10;
//     }
//     return ret;
// }

int CountIntsCorrespondingEquals(int n)
{
    int ret = 0;
    // int n1 = n / 10000;
    // int n1_ = n % 10;
    // int n2 = (n / 1000) % 10;
    // int n2_ = (n % 100) / 10;
    if (n / 10000 == n % 10) ret++;
    if ((n / 1000) % 10 == (n % 100) / 10) ret++;
    return ret;
}

Console.Write("Введите пятизначное число:");
int numb = Convert.ToInt32(Console.ReadLine());
// int numb = 23432;

// int bmun = ReverseInt(numb);
// Console.WriteLine("Перевернутое число: " + bmun);
int counNumb = CountIntsCorrespondingEquals(numb);

if (counNumb == 2) Console.WriteLine($"{numb} -> Да");
else Console.WriteLine($"{numb} -> Нет");
