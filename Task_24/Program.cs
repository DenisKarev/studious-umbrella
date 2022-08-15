// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Write("Введите число А: ");
int numA = Convert.ToInt32(Console.ReadLine());
int sumA = 0;

for (int i = 1; i <= numA; i++)
{
    // sum = sum + i;
    sumA += i;
}
Console.WriteLine ($"Сумма чисел от 1 до {numA} равна: " + sumA);
