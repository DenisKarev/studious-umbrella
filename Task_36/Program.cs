// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях (индексах).
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }

    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write(array[array.Length - 1]);
    Console.Write("]");
}

int SumOddElements(int[] array)
{
    int sumOdd = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sumOdd += array[i];
    }
    return sumOdd;
}

// Console.WriteLine("Введите размер массива:");
// int size = Convert.ToInt32(Console.ReadLine());
int size = 9;
int[] arr123 = CreateArrayRndInt(size, -99, 99);
PrintArray(arr123);
int sum = SumOddElements(arr123);
Console.WriteLine($" -> {sum}");