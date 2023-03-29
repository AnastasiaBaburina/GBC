// Домашнее задание №1

//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
/*
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
Console.WriteLine("min = " + num2);
Console.WriteLine("max = " + num1);
}
else if (num1 < num2)
{
Console.WriteLine("min = " + num1);
Console.WriteLine("max = " + num2);
}
else
Console.WriteLine("Числа равны");
*/

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;

if (num2 > max) max = num2;
if (num3 > max) max = num3;
Console.WriteLine("max = " + max);
*/

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
//является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

if 
    ((num1 % 2) == 1) Console.WriteLine("Число не является четным");
else 
    Console.WriteLine("Число является четным");
*/

//Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
/*
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

if 
    (N<=1) Console.WriteLine("Четных чисел в этом диапазоне нет");
else
{
    Console.WriteLine("Четные числа от 1 до " + N + ":");
    for (int i = 1; i < N+1; i++)
    {
        if (i % 2 == 0) Console.WriteLine(i);
    }
}
*/