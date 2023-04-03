// Домашнее задание №2

int secondDigit(int num)
{
    int secDigit = (num / 10) % 10;
    return secDigit;
}

int thirdDigit(int num)
{
    int res;
    if (num < 100) 
        return -1;
    else 
    {
        while (num >= 1000)
            num = num/10;
        res = num % 10;
        return res;
    }
}

//Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
/*
Console.Write("Введите трехзначное число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вторая цифра этого числа: " + secondDigit(num1));
*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
if (thirdDigit(num1) == -1)
    Console.WriteLine("Третьей цифры нет");
else
    Console.WriteLine("Третья цифра этого числа: " + thirdDigit(num1));

