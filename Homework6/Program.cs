// Домашнее задание №6

int[] CreateArray (int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++) array[i]= Convert.ToInt32(Console.ReadLine()); 
    return array;
}

void ShowArray (int[] array)
{
    for (int i = 0; i<array.Length; i++) Console.Write(array[i] + " ");
    Console.WriteLine();
}

void ShowDoubleArray (double[] array)
{
    for (int i = 0; i<array.Length; i++) Console.Write(array[i] + " ");
    Console.WriteLine();
}

int CountPositiveNumbers (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++) if (array[i] > 0) count+=1;
    return count;
}

double[] Intersection(double k1, double b1, double k2, double b2)
{
    double[] res = new double [2];
    res[0] = (b2 -b1) / (k1 - k2);
    res[1] = (res[0] * k1) + b1;
    return res; 
}

//Задача 41: Пользователь вводит с клавиатуры M чисел.
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
Console.Write("Введите значение M: ");
int M = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArray(M);
Console.WriteLine("Количество положительных чисел: " + CountPositiveNumbers(array));
*/
//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Задайте значения коэффициентов");
Console.Write("k1 = ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("b1 = ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("k2 = ");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("b2 = ");
int b2 = Convert.ToInt32(Console.ReadLine());

if (k1 == k2) Console.WriteLine("Прямые параллельны");
else Console.Write("Точка пересечения: ");
ShowDoubleArray(Intersection(k1, b1, k2, b2));