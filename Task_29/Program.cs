// Задача 29: Напишите программу, которая задаёт массив из 8
// элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] GenerateArray(int n, int min, int max)
{
    int[] mass = new int[n];
    // Console.WriteLine("Введите элементы массива (integers): ");
    for (int i = 0; i < mass.Length; i++)
    {
        // mass[i] = Convert.ToInt32(Console.ReadLine());
        mass[i] = new Random().Next(min, max);
    }
    return mass;
}

void PrintArray(int[] mas)
{
    Console.Write("[");
    for (int i = 0; i < mas.Length; i++)
    {
        if (i < mas.Length-1) Console.Write(mas[i] + ", ");
        else Console.Write(mas[i]);
    }
    Console.Write("]");
}

int siz = 8;
int[] arr = new int[siz];
arr = GenerateArray(siz, 1, 100);
PrintArray(arr);