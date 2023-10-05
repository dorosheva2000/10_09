/*
Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int InputSize(string massege)
{
    Console.Write(massege);
    return int.Parse(Console.ReadLine()!);
}

int[ , ] Create2DArray(int row, int col)
{
    return new int[row, col];
}

void Fill2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i ++)
    {
        for (int j = 0; j < array.GetLength(1); j ++)
        {
            array[i, j] = new Random().Next(2, 10);
        }
    }
}

void Print2Array(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i ++)
    {
        for (int j = 0; j < array.GetLength(1); j ++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine(" ");
    }
}

int MinSum(int[,] array)
{
    int [] suminfrow = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i ++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j ++)
        {
            sum += array[i,j];
        }
        suminfrow[i] = sum;
        sum = 0;
    }
    int min = suminfrow[0];
    int minindex = 0;
    for (int j = 1; j < suminfrow.Length; j ++)
    {
        if (suminfrow[j] < min)
        {
            min = suminfrow[j];
            minindex = j;
        }
    }
    return minindex + 1;
}

int m = InputSize("Введите количество строк: ");
int n = InputSize("Введите количество столбцов: ");
int[,] matrix = Create2DArray(m, n);
Fill2DArray(matrix);
Print2Array(matrix);
Console.WriteLine(" ");
Console.Write($"строка с наименьшей суммой элементов под номером: {MinSum(matrix)}");
