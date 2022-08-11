// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21


Console.WriteLine("Введите координаты точки A1:");
Console.Write("Xa: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Ya: ");
int ya = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B:");
Console.Write("Xb: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Yb: ");
int yb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Точка A {0}, {1}. Точка B {2}, {3}.", xa, ya, xb, yb);

double Hypotenuse(int x1, int y1, int x2, int y2)
{
    // Math.Sqrt ();
    return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
}

double hypot = Hypotenuse(xa, ya, xb, yb);
// Console.WriteLine(Math.Round(hypot, 2));
Console.WriteLine("{0:f3}", hypot);