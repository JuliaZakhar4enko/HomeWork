/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
/*
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write(inArray[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void SortArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            int maxPosition = j;
            for (int m = j + 1; m < inArray.GetLength(1); m++)
            {
                if (inArray[i, m] > inArray[i, maxPosition]) maxPosition = m;
            }
            int temp = inArray[i, j];
            inArray[i, j] = inArray[i, maxPosition];
            inArray[i, maxPosition] = temp;
        }
    }
}

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов массива: ");
int colomns = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(rows, colomns, 0, 10);
PrintArray(array);
Console.WriteLine();
SortArray(array);
PrintArray(array);
*/

/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
/*
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write(inArray[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void SumRows(int[,] inArray)
{
    int minRowSum = int.MaxValue, indexMinRow = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            sum = sum + inArray[i, j];
        }
        if (sum < minRowSum)
        {
            minRowSum = sum;
            indexMinRow = i + 1;
        }
    }
    Console.Write($"Номер строки с наименьшей суммой элементов: {indexMinRow} строка");
}

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов массива: ");
int colomns = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(rows, colomns, 0, 10);
PrintArray(array);
Console.WriteLine();
SumRows(array);
*/



/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
/*
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write(inArray[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void MultiArray(int[,] inArray1, int[,] inArray2)
{
    int[,] newArray = new int[inArray1.GetLength(0), inArray2.GetLength(1)];
    if (inArray1.GetLength(1) != inArray2.GetLength(0))
    { Console.WriteLine("Массивы нельзя перемножить"); }
    else
    {
        for (int i = 0; i < inArray1.GetLength(0); i++)
        {
            for (int j = 0; j < inArray2.GetLength(1); j++)
            {
                for (int l = 0; l < inArray2.GetLength(0); l++)
                {
                    newArray[i, j] += inArray1[i, l] * inArray2[l, j];
                }
                Console.Write(newArray[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

Console.Write("Введите количество строк для первого массива: ");
int rows1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов для первого массива: ");
int colomns1 = int.Parse(Console.ReadLine()!);
int[,] array1 = GetArray(rows1, colomns1, 0, 10);
PrintArray(array1);
Console.Write("Введите количество строк для второго массива: ");
int rows2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов для второго массива: ");
int colomns2 = int.Parse(Console.ReadLine()!);
int[,] array2 = GetArray(rows2, colomns2, 0, 10);
PrintArray(array2);
Console.WriteLine();
Console.WriteLine("Произведение двух массивов: ");
MultiArray(array1, array2);
*/

/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/