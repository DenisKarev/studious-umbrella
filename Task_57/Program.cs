// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

int[,] CreateMatrixRndInt(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)       // or i < row
    {
        for (int j = 0; j < matrix.GetLength(1); j++)   // or i < col
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3},");
            else Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine("]");
    }

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

int[] ConvertMatrix2ArrayAndSort(int[,] matrix)
{
    int[] result = new int[matrix.Length];
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            result[count] = matrix[i, j];
            count++;
        }
    }
    Array.Sort(result);
    return result;
}

void CountSimularElements(int[] array)
{
    int count = 1;
    int number = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == number) count++;
        else
        {
            Console.WriteLine($"{number} -> {count}");
            number = array[i];
            count = 1;
        }
        if (i == array.Length - 1)
        {
            Console.WriteLine($"{number} -> {count}");
        }
    }
}

string[] CountSimularElementsR(int[] array)
{
    string[] result = new string[10];
    int count = 1;
    int number = array[0];
    // result[0] = array[0].ToString();
    for (int i = 1; i < array.Length; i++)
    {
        result[number] = number.ToString();
        // result[number] = array[i].ToString();
        if (array[i] == number) count++;
        else
        {
            result[number] += " --> ";
            result[number] += count.ToString();
            number = array[i];
            count = 1;
        }
        if (i == array.Length - 1)
        {
            result[number] = number.ToString();
            result[number] += " --> ";
            result[number] += count.ToString();
        }
    }
    return result;
}

void PrintStringArr(string[] arrayS)
{
    for (int i = 0; i < arrayS.Length; i++)
    {
        if(arrayS[i] != null) Console.WriteLine(arrayS[i]);
    }
}

int[,] matr = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(matr);

Console.WriteLine();
int[] arr = ConvertMatrix2ArrayAndSort(matr);
PrintArray(arr);

CountSimularElements(arr);
Console.WriteLine();
string[] printS = CountSimularElementsR(arr);
// PrintArray(arr);
PrintStringArr(printS);