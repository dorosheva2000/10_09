/*
Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int[ , ] Create2DArray()
{
    return new int[4, 4];
}

void Fill2DArray(int[,] array)
{
    for (int i = 0; i < 2; i ++)
    {
        int e = 1;
        int n1 = 0;
        for (int r = n1; r < (4 - n1); r ++) // цикл вправо
        {
            array[n1, r] = e;
            e += 1;
        }
        for (int d = n1; d < (4 - n1); d ++) // цикл вниз
        {
            array[d, 3 - n1]  = e;
            e += 1;
        }
        for (int l = (3 -n1); l > n1; l --) // цикл влево
        {
            array[3 - n1, l] = e;
            e += 1;
        }
        for (int u = (3 - n1); u > n1; u --)
        {
            array[u, n1] = e;
            e += 1;
        }
        n1 += 1;
    }
    array[4 / 2 - 1, 4 / 2 - 1] = 4*4 - 3;
    array[4 / 2 - 1, 4 / 2] = 4*4 - 2;
    array[4 / 2, 4 / 2] = 4*4 - 1;
    array[4 / 2, 4 / 2 - 1] = 4*4;
    
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

int[,] myarr = Create2DArray();
Fill2DArray(myarr);
Print2Array(myarr);