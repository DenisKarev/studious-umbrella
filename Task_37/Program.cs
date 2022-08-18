// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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

int[] CountElemsInArray(int[] array)
{
    int resASize = array.Length / 2;
    if (array.Length % 2 != 0) resASize++;

    int[] resArray = new int[resASize];

    for (int i = 0; i < resASize; i++)
    {
        resArray[i] = array[i] * array[array.Length - i - 1];
    }
    
    if (array.Length % 2 != 0) resArray[resASize-1] = array[resASize-1];
    return resArray;
}

int[] arr = CreateArrayRndInt(7, 0, 10);
PrintArray(arr);
int[] resarr = CountElemsInArray(arr);
PrintArray(resarr);
