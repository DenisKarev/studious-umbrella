// Задача 63: 
// Задача 65: 

void NaturalIntegersOne2N(int value)
{
    if (value == 0) return;
    Console.Write($"{value} ");
    // NaturalIntegersOne2N(value - 1);        // 5 4 3 2 1 
    NaturalIntegersOne2N(value - 1);        // 1 2 3 4 5
}

Console.WriteLine("Enter positive integer N:");
int numberN = Convert.ToInt32(Console.ReadLine());

Console.Write($"N = {numberN} -> \" ");
NaturalIntegersOne2N(numberN);
Console.Write("\"");