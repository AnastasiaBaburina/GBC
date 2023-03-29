// Домашнее задание №1

//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.

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

