// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine("Введите число N:");
int a = Convert.ToInt32(Console.ReadLine());

void FiboN(int n)
{
    int res1=0, res2=1;
    Console.Write($"Если N = {n} -> {res1} {res2} ");
    for (int i = 2; i < n; i++)
    {
        int resn = res1 + res2; 
        Console.Write($"{resn} ");
        res1 = res2;
        res2 = resn;
    }
}

FiboN(a);