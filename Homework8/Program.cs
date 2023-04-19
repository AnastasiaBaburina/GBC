// Домашнее задание №7

int[,] CreateRandomArray ()
{
    Console.Write("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Минимальное возможное значение: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Максимальное возможное значение: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int [rows,columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1); 
   
    return array;
}

void Show2DArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) 
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void SortMaxToMin (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i,j] < array[i,k])
                {
                    int temp = array[i,j];
                    array[i,j] = array[i,k];
                    array[i,k] = temp;
                }
            }

}

int MinRow (int[,] array)
{
    int row = 0;
    int minSum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
        minSum = minSum + array[0,j];

    for (int i = 1; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i,j];
        }
        if (sum < minSum)
        {
            row = i;
            minSum = sum;
        }
    } 
    return row;
}


//Задача 54: Задайте двумерный массив.
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
int [,] array = CreateRandomArray();
Show2DArray(array);
SortMaxToMin(array);
Show2DArray(array);
*/
//Задача 56: Задайте прямоугольный двумерный массив.
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
int [,] array = CreateRandomArray();
Show2DArray(array);
Console.WriteLine("Строка с наименьшей суммой элементов: " + (MinRow(array) + 1) );
*/


