/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

// Способ 0
// Console.Write("Введите любое количество чисел, через пробел: ");
// string array1 = Console.ReadLine()!;
// string[] arr = array1.Split(" ");
// Count(arr);

// void Count(string[] m)
// {
//     int count = 0;
//     for (int j = 0; j < m.Length; j++)
//     {
//         if (int.Parse(m[j]) > 0) count++;
//         Console.Write(m[j] + " ");
//     }
//     Console.WriteLine($"--> Количество чисел больше нуля  = {count}");
// }


//СПОСОБ №1!!!!
// Console.Write("Введите любое количество чисел, через пробел: ");
// string array1 = Console.ReadLine()!;
// string[] arr = array1.Split(" ");
// Array(array1);
// Count(arr);
// void Array(string array1)
// {
//     int i = 0;
//     while (i < arr.Length - 1)
//     {
//         Console.Write($"{arr[i]}, ");
//         i++;
//     }
//     Console.Write(arr[i]);
// }
// void Count(string[] m)
// {
//     int count = 0;
//     for (int j = 0; j < m.Length; j++)
//     { if (int.Parse(m[j]) > 0) count++; }
//     Console.WriteLine($"--> Количество чисел больше нуля  = {count}");
// }


/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
/*
Console.Write("Введите b1 = ");
double b1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите k1 = ");
double k1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите b2 = ");
double b2 = double.Parse(Console.ReadLine()!);
Console.Write("Введите k2 = ");
double k2 = double.Parse(Console.ReadLine()!);
Point(b1, k1, b2, k2);

void Point(double b1, double k1, double b2, double k2)
{
    double x = 0;
    double y = 0;
    if (k1 == k2 && b1 != b2) Console.WriteLine("Прямые параллельны, точек пересечения нет");
    else if (k1 == k2 && b1 == b2)
    {
        Console.WriteLine("Прямые совпадают");
    }
    else
    {
        y = (k1 * b2 - k2 * b1) / (k1 - k2);
        x = (y - b2) / k2;
        Console.WriteLine($"Точка пересечения заданных прямых: ({x}; {y})");
    }
}
// Console.WriteLine(Math.Round((decimal)x, 2));

*/

/*
Задача НЕГАФИБОНАЧЧИ. Задайте число. Составьте массив чисел НегаФибоначчи, в том числе для отрицательных индексов.
Пример:
для k = 9 массив будет выглядеть так: [-21 ,13, -8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21]
*/

// int[] Fibonachi(int num)
// {
//     int[] array = new int[num];
//     array[0] = 1;
//     array[1] = -1;
//     for (int i = 2; i < num; i++)
//     {
//         array[i] = array[i + 2] - array[i - 1];
//     }
//     return array;
// }


// void PrintArray(int[] array)
// {
//     foreach (int item in array)
//         Console.Write($"{item} ");

// }

// System.Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// PrintArray(Fibonachi(num));


/*
задача 40 - HARD необязательная. 
На вход программы подаются три целых положительных числа. Определить ,
является ли это сторонами треугольника. Если да, то вывести всю информацию по нему - площадь, периметр, значения углов треугольника в градусах,
 является ли он прямоугольным, равнобедренным, равносторонним.
*/