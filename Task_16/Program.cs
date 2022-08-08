// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine("Enter number 1");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number 2");
int secondNumber = Convert.ToInt32(Console.ReadLine());

bool CheckNumber(int num1, int num2)
{
    if (num1 * num1 == num2) return true;
    else if (num2 * num2 == num1) return true;
    else return false;
}

// return num1*num1 == num2 || num2 *num2  == num1;

bool yes = CheckNumber(firstNumber, secondNumber);

if (yes) Console.WriteLine("Да");
else Console.WriteLine("Нет");