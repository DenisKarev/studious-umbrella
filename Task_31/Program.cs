// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.

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

int[] GetSumPosNeElemInArray(int[] array)
{
    int sumPos = 0;
    int sumNeg = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            sumPos += array[i];
        else
            sumNeg += array[i];
    }

    return new int[] { sumPos, sumNeg };
}

int[] arr = CreateArrayRndInt(12, -9, 9);
int[] sums = GetSumPosNeElemInArray (arr);
PrintArray(arr);
Console.WriteLine();
Console.WriteLine($"Сумма положительных чисел: {sums[0]}");
Console.WriteLine($"Сумма отрицательных чисел: {sums[1]}");