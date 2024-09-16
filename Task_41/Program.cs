// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько
//  чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

//                                  // метод чтения чисел через цикл
// int[] ReadMNumbers(int size)
// {
//     int[] res = new int[size];
//     Console.WriteLine("Введите M целых чисел ({0}):", size);
//     for (int i = 0; i < size; i++)
//     {
//         Console.Write("Введите число {0}: ", i + 1);
//         res[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return res;
// }

int[] ConvertToInts(string[] param)
{
    int[] res = new int[param.Length];
    for (int i = 0; i < param.Length; i++)
    {
        res[i] = Convert.ToInt32(param[i]);
    }
    return res;
}

int CountAboveZero(int[] param)
{
    int res = 0;
    for (int i = 0; i < param.Length; i++)
    {
        if (param[i] > 0) res++;
    }
    return res;
}

void PrintArray(int[] array)
{
    // Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
    }
    Console.Write(array[array.Length - 1]);
    Console.Write(". ");
}

Console.WriteLine("Введите число M:");
int mNum = Convert.ToInt32(Console.ReadLine());
// int[] numbers = ReadMNumbers(mNum);          // Чтение чисел через цикл

Console.WriteLine("Введите M целых чисел ({0}) разделяя пробелами:", mNum);
string[] numsS = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

if (numsS.Length != mNum) Console.WriteLine("Введено неверное количество цифр!");
else
{
    int[] numsInts = ConvertToInts(numsS);
    PrintArray(numsInts);
    Console.WriteLine("  Чисел больше 0 --> {0}", CountAboveZero(numsInts));
}

// PrintArray(numbers);          // Для чтения чисел через цикл
// Console.WriteLine("  Чисел больше 0 --> {0}", CountAboveZero(numbers, mNum));