// Домашнее задание №8

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
        {
            if (array[i,j] < 10) Console.Write("0" + array[i,j] + " ");
            else Console.Write(array[i,j] + " "); 
        }
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
            sum = sum + array[i,j];
        if (sum < minSum)
        {
            row = i;
            minSum = sum;
        }
    } 
    return row;
}

int [,] MatrixProduct (int[,] array1, int[,] array2)
{
    int[,] result = new int [array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < result.GetLength(0); i++)
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i,j] = 0;
            for (int k = 0; k < array1.GetLength(1); k++) 
                result[i,j] = result[i,j] + (array1[i,k] * array2[k,j]);
        }
    return result;
}

int [] CreateNonrepeatingArray (int N)
{
    int [] variations = new int [N];
    variations[0] = new Random().Next(10, 100);
    for (int i = 1; i < N; i++)
    {
        bool flag = false;
        do
        {
            variations[i] = new Random().Next(10, 100);
            flag = true;
            for (int i2 = 0; i2 < i; i2++)
                if (variations[i] == variations[i2]) flag = false;
        }
        while (flag == false);
    }
    return variations;
}

int [,,] Create3DArray ()
{
    Console.Write("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите глубину: ");
    int depth = Convert.ToInt32(Console.ReadLine());

    //Создаю нужное количество неповторяющихся двузначных чисел
    int [] variations = CreateNonrepeatingArray(rows*columns*depth);

    int[,,] array = new int [rows,columns,depth];
    //Заполняю массив созданными ранее значениями
    int index = 0;
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            for (int k = 0; k < depth; k++)
            {
               array[i,j,k] = variations[index];
               index+=1;
            }
    return array;
}

void Show3DArray (int[,,] array)
{
    for (int k = 0; k < array.GetLength(2); k++)
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                Console.Write(array[i,j,k] + "(" + i + "," + j + "," + k + ")" + " ");
            Console.WriteLine();
        }
    Console.WriteLine();
}

int[,] SpiralArray (int rows, int columns)
{
    int[,] array = new int [rows, columns];
    int value = 1;
    for (int a = 0; a < rows; a++)
        for (int b = 0; b < columns; b++)
            array[a,b] = 0;

    int x = 0;
    int y = 0;
    do
    {
        for (int j = y; j < columns - y; j++) 
        { 
            if (array[x,j]==0)
            {
                array[x,j] = value;
                value+=1;
            }
        }
        for (int i = 1 + x; i < rows - x; i++)
        {
            if (array[i,columns - 1 - y]==0)
            {
                array[i,columns - 1 - y] = value;
                value+=1;
            }
        }
        for (int j = columns - 2 - y; j >= 0 + y; j--)
        {
            if (array[rows - 1 - x, j] == 0)
            {
                array[rows- 1 - x, j] = value;
                value+=1;
            }
        }
        for (int i = rows - 2 - x; i > 0 + x; i--)
        {
            if (array[i,y]==0)
            {
                array[i,y] = value;
                value+=1;
            }
        }
        x+=1;
        y+=1;
    }
    while (value < rows*columns + 1);
    
    return array;
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
//Задача 58: Задайте две матрицы.
//Напишите программу, которая будет находить произведение двух матриц.
/*
Console.WriteLine("Первая матрица: ");
int [,] array1 = CreateRandomArray();
Show2DArray(array1);
Console.WriteLine("Вторая матрица: ");
int [,] array2 = CreateRandomArray();
Show2DArray(array2);

if (array1.GetLength(1)!=array2.GetLength(0))
    Console.WriteLine("Умножение этих матриц невозможно");
else 
{
    Console.WriteLine("Произведение матриц: ");
    Show2DArray(MatrixProduct(array1, array2));
}
*/
//Задача 60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
int[,,] array = Create3DArray();
Show3DArray(array);
*/
//Задача 62. Напишите программу, которая заполнит спирально массив 
/*
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = SpiralArray(rows,columns);
Show2DArray(array);
*/

