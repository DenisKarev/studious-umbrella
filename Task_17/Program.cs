// 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.

Console.WriteLine("Введите координаты точки :");
Console.Write("X: ");
int xCoord = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yCoord = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Координаты {0}, {1}", xCoord, yCoord);

string Quarter(int c1, int c2)      // можно без else потому-что return -> выход из метода!
{
    if (c1 > 0 && c2 > 0) return "Четверть 1";
    if (c1 < 0 && c2 > 0) return "Четверть 2";
    if (c1 < 0 && c2 < 0) return "Четверть 3";
    if (c1 < 0 && c2 > 0) return "Четверть 4";
    return "Одна из координат равна 0. Введите правильные координаты";
}

string q = Quarter(xCoord, yCoord);
Console.WriteLine(q);



// if (xCoord > 0 && yCoord > 0)       Console.WriteLine("Четверть 1");
// else if (xCoord < 0 && yCoord > 0)  Console.WriteLine("Четверть 2");
// else if (xCoord < 0 && yCoord < 0)  Console.WriteLine("Четверть 3");
// else if (xCoord < 0 && yCoord > 0)  Console.WriteLine("Четверть 4");
// else Console.WriteLine("Одна из координат равна 0. Введите правильные координаты");
