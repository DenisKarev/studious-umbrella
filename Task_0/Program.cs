// Task zero
// Напишите программу, которая на вход
// принимает число и выдаёт его квадрат (число
// умноженное на само себя).
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.Write("Enter an integer, plz: ");
int numB = Convert.ToInt32(Console.ReadLine()); // from -2 147 483 648 to 2 147 483 648
// double d = 4.454;
Console.Write("Enter a long number, plz: ");
long numL = Convert.ToInt64(Console.ReadLine());
// Console.Write("Sqr of your number is: ");
Console.WriteLine($"Sqr of your int:{numB} is: {numB*numB}");
Console.WriteLine($"Sqr of your long:{numL} is: {numL*numL}");
// Console.WriteLine(numB*numB);
// Console.Write("Sqr of your double is: ");
// Console.WriteLine(d*d);

// or
// int sqr = numB * numB;
// Console.Write("Sqr of your number is: ");
// Console.WriteLine(sqr);