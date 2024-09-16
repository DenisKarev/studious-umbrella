// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// x = (b2 - b1) / (k1 - k2)

Console.WriteLine("Введите b1:");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите k1:");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите b2:");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите k2:");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y1 = k1 * x + b1;
double y2 = k2 * x + b2;

// Console.WriteLine("Проверка %)) x = {0:F3} , y1 = {1:F3} , y2 = {2:F3}", x, y1, y2);
// Console.Write("b1 = {0:F3} k1 = {1:F3} b2 = {2:F3} k2 = {3:F3}", b1, k1, b2, k2);

Console.Write("b1 = {0:F1}  k1 = {1:F1}  b2 = {2:F1}, k2 = {3:F1}", b1, k1, b2, k2);
Console.WriteLine(" -> ({0:F2}; {1:F2}) ", x, y1);