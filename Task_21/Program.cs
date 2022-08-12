// Задача 21 Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между ними в
// 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки A:");
Console.Write("xA: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("yA: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("zA: ");
int za = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B:");
Console.Write("xB: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("yB: ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.Write("Zb: ");
int zb = Convert.ToInt32(Console.ReadLine());

// int xa = 3, ya = 6, za = 8;
// int xb = 2, yb = 1, zb = -7;

// int xa = 7, ya = -5, za = 0;
// int xb = 1, yb = -1, zb = 9;

Console.WriteLine("Точка A {0}, {1}, {2}. Точка B {3}, {4}, {5}.", xa, ya, za, xb, yb, zb);

double DistanceAB(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double dist1 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
    return Math.Sqrt(Math.Pow((z2 - z1), 2) + Math.Pow((dist1), 2));
}

double distAB = DistanceAB(xa, ya, za, xb, yb, zb);
Console.WriteLine(Math.Round(distAB, 2));
// Console.WriteLine("{0:f3}", distAB);