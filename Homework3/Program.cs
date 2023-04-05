// Домашнее задание №3

bool palindrome (int num)
{
    if (num % 10 != num / 10000) return false;
    if ((num / 10) % 10 != (num / 1000) % 10) return false;
    return true;
}

double distance (double x1, double y1, double z1, double x2, double y2, double z2)
{
    double res;
    res = Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2) + Math.Pow((z2-z1),2));
    return res;
}


//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет,
//является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if ((num >= 10000) && (num < 100000))
{
    if (palindrome(num) == true) Console.WriteLine("Число является палиндромом ");
    else Console.WriteLine("Число не является палиндромом ");
}
else Console.WriteLine("Вы ввели неверное число ");


//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек
//и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координаты двух точек");
Console.Write("x1: ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y1: ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("z1: ");
double z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("x2: ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y2: ");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("z2: ");
double z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Расстояние между этими точками = " + Math.Round(distance(x1, y1, z1, x2, y2, z2), 2));
