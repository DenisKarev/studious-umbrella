// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Enter number");
int number = Convert.ToInt32(Console.ReadLine());

bool CheckNumber (int num)
{
if (number % 7 == 0 && number % 23 == 0)return true;
else return false;
}

bool yes = CheckNumber (number);

if (yes) Console.WriteLine("Да");
else Console.WriteLine("Нет");
