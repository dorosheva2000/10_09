/*
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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

bool AbilityToMultiply(int[,] arr1, int[,] arr2)
{
    if(arr1.GetLength(1) == arr2.GetLength(0)) return true;
    else return false;
}

int[,] MatrixMultiply(int[,] arr1, int[,] arr2)
{
    int[,] res = new int[arr1.GetLength(0), arr2.GetLength(1)];
    for(int i =0; i < arr1.GetLength(0); i ++)
    {
        for(int j = 0; j < arr2.GetLength(1); j ++)
        {
            res[i, j] = 0;
            for(int k = 0; k < arr1.GetLength(1); k ++)
            {
                res[i, j] += arr1[i, k] * arr2[k, j]; 
            }
        }
    }
    return res;
}

int m = InputSize("Введите количество строк 1 матрицы: ");
int n = InputSize("Введите количество столбцов 1 матрицы: ");
int[,] matrix1 = Create2DArray(m, n);
Fill2DArray(matrix1);
Print2Array(matrix1);
Console.WriteLine(" ");
int q = InputSize("Введите количество строк 2 матрицы: ");
int p = InputSize("Введите количество столбцов 2 матрицы: ");
int[,] matrix2 = Create2DArray(q, p);
Fill2DArray(matrix2);
Print2Array(matrix2);
Console.WriteLine(" ");
if (AbilityToMultiply(matrix1, matrix2) == true)
{
    int[,] result = MatrixMultiply(matrix1, matrix2);
    Print2Array(result);
}
else
{
    Console.WriteLine("Невозможно перемножить матрицы!");
}