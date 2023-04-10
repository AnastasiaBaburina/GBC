// Домашнее задание №5

int[] CreateRandomArray (int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++) array[i]= new Random().Next(min, max + 1); 
    return array;
}

void showArray (int[] array)
{
    for (int i = 0; i<array.Length; i++) Console.Write(array[i] + " ");
    Console.WriteLine();
}

int CountEven (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}

int SumOdd (int[] array)
{
    int sum = 0 ;
    for (int i = 0; i < array.Length; i+=2)
    {
        sum = sum + array[i];
    }
    return sum;
}

double DifferenceOfValues (double[] array)
{
    int imin = 0;
    int imax = 0;
    for (int i = 0; i < array.Length; i++){
        if (array[i] < array[imin]) imin = i;
        if (array[i] > array[imax]) imax = i;
    }
    double difference = array[imax] - array[imin];
    return difference;
}

//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
/*
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(size, 100, 999);
showArray(myArray);
Console.Write("Количество четных чисел в массиве: " + CountEven(myArray));
*/
//Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
/*
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте диапазон значений: ");
Console.Write("min = ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("max = ");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(size, min, max);
showArray(myArray);
Console.Write("Сумма элементов, стоящих на нечётных позициях: " + SumOdd(myArray));
*/
//Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
/*
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];
Console.WriteLine("Введите значения: ");
for (int i = 0; i < size; i++)
{
    array[i] = Convert.ToDouble(Console.ReadLine());
}
for (int i = 0; i<array.Length; i++) Console.Write(array[i] + " ");
Console.WriteLine();
Console.Write("Разница между максимальным и минимальным элементом: " + DifferenceOfValues(array));
*/
