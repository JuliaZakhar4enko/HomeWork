// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

/*
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(-30, 30);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            System.Console.Write($"{array[i, j],3}    ");
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}


void ChangeArray (int [,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        (array[0,j], array[array.GetLength(0)-1,j]) =(array[array.GetLength(0)-1,j],array[0,j]);
    }
}

// 2 3 4 5 
// 2 5 5 6
// 3 3 3 3
// 3 2 2 2


Console.Clear();
Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
FillArray(array);
PrintArray(array);
ChangeArray(array);
PrintArray(array);
*/