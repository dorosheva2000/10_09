/*
Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int InputSize(string massege)
{
    Console.Write(massege);
    return int.Parse(Console.ReadLine()!);
}

void SortRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i ++)
    {
        for (int j = 0; j < array.GetLength(1); j ++)
        {
            for (int k = j + 1; k < array.GetLength(1); k ++)
            {
                if(array[i, j] < array[i, k])
                {
                    int max = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = max;
                }
            }  
        }
    }
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


int m = InputSize("Введите количество строк: ");
int n = InputSize("Введите количество столбцов: ");
int[,] matrix = Create2DArray(m, n);
Fill2DArray(matrix);
Print2Array(matrix);
Console.WriteLine(" ");
SortRows(matrix);
Print2Array(matrix);
