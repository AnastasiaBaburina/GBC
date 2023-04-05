// Домашнее задание №3

//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

bool palindrome (int num)
{
    bool flag = true;
    if (num % 10 != num / 10000) flag = false;
    if ((num / 10) % 10 != (num / 1000) % 10) flag = false;
    return flag;
}

Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if ((num >= 10000) && (num < 100000))
{
    if (palindrome(num) == true) Console.Write("Число является палиндромом");
    else Console.Write("Число не является палиндромом");
}
else Console.Write("Вы ввели неверное число");