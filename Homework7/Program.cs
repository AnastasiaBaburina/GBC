// Домашнее задание №7

double[,] CreateRandomDoubleArray ()
{
    Console.Write("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Минимальное возможное значение: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Максимальное возможное значение: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    double[,] array = new double [rows,columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i,j] = new Random().NextDouble() * (maxValue - minValue) + minValue;; 
   
    return array;
}

void ShowDouble2DArray (double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) 
            Console.Write(Math.Round(array[i,j],3) + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ElementPosition (double[,] array, int row, int column)
{
    if ( row >= array.GetLength(0) || column >= array.GetLength(1))
        Console.WriteLine("Элемента с такими индексами в массиве нет");
    else Console.WriteLine(Math.Round(array[row,column],3));
}

//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] doubleArray = CreateRandomDoubleArray();
ShowDouble2DArray(doubleArray);

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

//Буду использовать массив из предыдущей задачи
Console.WriteLine("Задайте индексы элемента");
Console.Write("Строка: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Столбец: ");
int column = Convert.ToInt32(Console.ReadLine());
ElementPosition(doubleArray, row, column);

//ПРОВЕРЬ ВТООРУЮ