// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

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

int[] CopyArrayInt(int[] array)
{
    int[] array1 = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        array1[i] = array[i];
    }
    return array1;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
    }
    Console.Write(array[array.Length - 1]);
    Console.WriteLine("]");
}

int[] arr = CreateArrayRndInt(15, 1, 9);
int[] arr1 = CopyArrayInt(arr);
arr1[arr1.Length-1] = 12;
PrintArray(arr);
PrintArray(arr1);