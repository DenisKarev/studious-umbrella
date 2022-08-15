// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] GenerateArray(int n, int min, int max)
{
    int[] mass = new int[n];
    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = new Random().Next(min, max);
    }
    return mass;
}

// void PrintArray(int[] mas)
// {
//     string txt = "[";
//     for (int i = 0; i < mas.Length; i++)
//     {
//         txt = txt + mas[i] + ", ";
//     }
//     txt = txt + mas[mas.Length-1] + "]";
//     Console.Write($"{txt} ");
// }

// void PrintArray(int[] mas)
// {
//     // string txt = "[";
//     for (int i = 0; i < mas.Length; i++)
//     {
//         if (i == 0) Console.Write("[");
//         if (i < mas.Length) Console.Write(mas[i] + ", ");
//         else Console.Write(mas[i] + "]");
//     }
// }

void PrintArray(int[] mas)
{
    Console.Write("[");
    for (int i = 0; i < mas.Length; i++)
    {
        if (i < mas.Length) Console.Write(mas[i] + ", ");
        else Console.Write(mas[i]);
    }
    Console.Write(mas[mas.Length-1]);
    Console.Write("]");
}

int siz = 11;
int[] arr = new int[siz];
arr = GenerateArray(siz, 2, 5);
PrintArray(arr);