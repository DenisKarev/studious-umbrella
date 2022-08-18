// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

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
    Console.WriteLine("]");
}

int[] InvertArrayElems (int[] array)
{
    int[] temp = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = -array[i];
    }
    return temp;
}

int[] arr = CreateArrayRndInt (12, -9, 9);
PrintArray(arr);
InvertArrayElems (arr);
PrintArray(arr);