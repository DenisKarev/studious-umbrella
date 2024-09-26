// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int range)
{
    double[] array = new double[size];
    Random rnd = new Random();
    // int range = (-min + max) / 2;
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.NextDouble() * range;
    }

    return array;
}

void PrintDoublesArray(double[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write("{0:N} | ", array[i]);
    }
    Console.Write("{0:N}", array[array.Length - 1]);
    Console.Write(" ]");
}

// int[] FindMinMaxIndexes(double[] array)
// {
//     int[] indexes = { 0, 0 };
//     for (int i = 1; i < array.Length; i++)
//     {
//         if (array[indexes[0]] > array[i]) indexes[0] = i;
//         if (array[indexes[1]] < array[i]) indexes[1] = i;
//     }
//     return indexes;
// }

double FindMin(double[] array)
{
    double minimum = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (minimum > array[i]) minimum = array[i];
    }
    return minimum;
}
double FindMax(double[] array)
{
    double maximum = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (maximum < array[i]) maximum = array[i];
    }
    return maximum;
}

double FindMaxMinDifference (double[] array)
{
    double minimum = array[0];
    double maximum = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (minimum > array[i]) minimum = array[i];
        if (maximum < array[i]) maximum = array[i];
    }
    return maximum - minimum;
}

// Console.WriteLine("Введите размер массива:");
// int size = Convert.ToInt32(Console.ReadLine());
int size = 9;
double[] arr123 = CreateArrayRndDouble(size, 100); // size 9, range 0...99 ?
PrintDoublesArray(arr123);
// int[] minmax = new int[2];
// minmax = FindMinMaxIndexes(arr123);
// Console.WriteLine(" -> {0:N} ", (arr123[minmax[0]] - arr123[minmax[1]]));

double min = FindMin(arr123);
double max = FindMax(arr123);
double result = FindMaxMinDifference(arr123);
Console.WriteLine(" -> {0:N} ", result);
Console.WriteLine(" -> {0:N} ", (max - min));
Console.WriteLine("min: {0:N} max: {1:N}", min, max);
// foreach (var value in arr123)
//    Console.WriteLine(value);
// .ToString("N", new System.Globalization.CultureInfo("en-US"))