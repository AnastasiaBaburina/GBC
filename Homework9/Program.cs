﻿// Домашнее задание №9

void PrintNum (int N)
{
    if (N > 0)
    {
    Console.Write(N + " ");
    if (N > 1) PrintNum(N-1);
    }
    else
    {
        Console.Write(N + " ");
        if (N < 1) PrintNum(N + 1); 
    }
}

//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
//Выполнить с помощью рекурсии.

Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
PrintNum(N);
