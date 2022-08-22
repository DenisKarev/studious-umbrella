// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

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
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
    }
    Console.Write(array[array.Length - 1]);
    Console.Write("]");
}

// Array.Reverse(arr);  // встроенная функция
void ReverseArrayWhile(int[] array)
{
    int size = array.Length;
    int ind0 = 0, ind1 = size - 1;
    while (ind0 < ind1)
    {
        int temp = array[ind0];
        array[ind0] = array[ind1];
        array[ind1] = temp;
        ind0++;
        ind1--;
    }
}
void ReverseArrayFor(int[] array)
{
    int size = array.Length;
    for (int i = 0; i < size / 2; i++)
    {
        int temp = array[i];
        array[i] = array[size - i - 1];
        array[size - i - 1] = temp;
    }
}

int[] arr = CreateArrayRndInt(5, 1, 9);
PrintArray(arr);
Console.WriteLine();
ReverseArrayWhile(arr);
PrintArray(arr);
Console.WriteLine();
ReverseArrayFor(arr);
PrintArray(arr);