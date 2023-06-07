//Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
 //В случае, если это невозможно, программа должна вывести сообщение для пользователя.


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

void ChangeAr(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i; j < array.GetLength(1); j++)
        {
            // int temp =array[i,j];
            // array[i,j] =array[j,i];

            (array[i, j], array[j, i]) = (array[j, i], array[i, j]);

        }

    }
}


Console.Clear();
Console.WriteLine("Введите количество строк и столбцов");
int rows = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, rows];
FillArray(array);
PrintArray(array);
ChangeAr(array);
PrintArray(array);
*/