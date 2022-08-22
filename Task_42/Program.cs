// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10
// 13 -> 1101

Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());

int ChangeToBinary(int n)
{
    int res = 0;
    int iter = 1;
    while (n > 0)
    {
        res += n % 2 * iter;
        n /= 2;
        iter *= 10;
    }
    return res;
}
void DecToBin(int n)
{
    if (n == 0) return;
    DecToBin(n / 2);
    Console.Write(n % 2);
}

Console.WriteLine($"Binary of number {a}: {ChangeToBinary(a)}");
DecToBin(a);