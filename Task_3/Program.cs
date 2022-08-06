//3. Напишите программу, которая будет выдавать
//название дня недели по заданному номеру.
//3 -> Среда
//5 -> Пятница

// week = ["Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"]

string day_Str = " ";
Console.Write("Enter numer of a day: ");
int day_N = Convert.ToInt32(Console.ReadLine());
if (day_N >= 1 && day_N <=7 )
{
    switch (day_N)
    {
        case 1:
            day_Str = "Понедельник";
            break;
        case 2:
            day_Str = "Вторник";
            break;
        case 3:
            day_Str = "Среда";
            break;
        case 4:
            day_Str = "Четверг";
            break;
        case 5:
            day_Str = "Пятница";
            break;
        case 6:
            day_Str = "Суббота";
            break;
        case 7:
            day_Str = "Воскресенье";
            break;
    }
    Console.WriteLine($"the day is: {day_Str}");
}
else
{
    Console.WriteLine("Icorrect number!!!");
}

// DO NOT DO LIKE THIS
// string str = "12345";
// string res = str[0].ToString(); //1
// string res = str[1].ToString(); //2

// int a=1, b=2,c=3,d=8, e=4, max=a;

// if (a>max) max=a;
// if (b>max) max=b;
// if (c>max) max=c;
// if (d>max) max=d;
// if (e>max) max=e;

// Console.Write("max = ");
// Console.WriteLine(max);