// Домашнее задание №6

int[] CreateArray (int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++) array[i]= Convert.ToInt32(Console.ReadLine()); 
    return array;
}

int CountPositiveNumbers (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++) if (array[i] > 0) count+=1;
    return count;
}

//Задача 41: Пользователь вводит с клавиатуры M чисел.
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Введите значение M: ");
int M = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArray(M);
Console.WriteLine("Количество положительных чисел: " + CountPositiveNumbers(array));

