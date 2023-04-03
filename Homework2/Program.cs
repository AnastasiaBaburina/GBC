// Домашнее задание №2

int secondDigit(int num)
{
    int secDigit = (num / 10) % 10;
    return secDigit;
}

//Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трехзначное число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вторая цифра этого числа: " + secondDigit(num1));


