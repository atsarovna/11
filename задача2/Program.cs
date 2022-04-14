int a = 1;
int b = 2;
int c = 3;
int d = 4;
int e = 5;
int f = 6;
int g = 7;

Console.Write("Введите число для определения дня недели :");
int day = Convert.ToInt32(Console.ReadLine());

if (day == a)
{
    Console.WriteLine("Понедельник");
}
else if (day == b)
{
    Console.WriteLine("Вторник");
}
else if (day == c)
{
    Console.WriteLine("Среда");
}
else if (day == d)
{
    Console.WriteLine("Четверг");
}
else if (day == e)
{
    Console.WriteLine("Пятница");
}
else if (day == f)
{
    Console.WriteLine("Суббота");
}
else if (day == g)
{
    Console.WriteLine("Воскресенье");
}

else Console.WriteLine("Введите число от 1 до 7");
//программа,которая определяет день недели по цифре от 1 до 7
