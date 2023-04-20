// Домашнее задание №9

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

int SumMtoN (int M, int N)
{
    if (M < N)
    {
        if (M != N) return M + SumMtoN(M + 1, N);
    }
    if (M > N)
    {
        if (M != N) return M + SumMtoN(M - 1, N);
    }
    return N;
}
//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
//Выполнить с помощью рекурсии.
/*
Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
PrintNum(N);
*/
//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.Write("Введите M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumMtoN(M,N));

