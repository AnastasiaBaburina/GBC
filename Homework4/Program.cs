// Домашнее задание №4

double numPower (double num, int pow)
{
    if (pow == 0) return 1;
    double res =1;
    for (int i = 1; i < pow + 1; i++) res = res * num;
    return res;
}

//Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
//и возводит число A в натуральную степень B.

Console.Write("Введите число: ");
double num = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите степень, в которую необходимо возвести число: ");
int pow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{num} в степени {pow} = {numPower(num, pow)}");
