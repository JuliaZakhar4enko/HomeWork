/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
/*
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 999);
}

void PrintArray(int[] array)
{
    foreach (int item in array)
        Console.Write($"{item} ");
    System.Console.WriteLine();
}

int SearchNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2==0)
        count++;
    }
    return count;
}

int [] array = new int[15];
FillArray(array);
PrintArray(array);
Console.WriteLine($"Число: {SearchNumbers(array)}");
*/


/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
  int[]array = new int [size];
  for (int i = 0; i < size; i++)
  array[i]=new Random().Next(minValue,maxValue+1);
  return array;
}

void WriteArray(int[]array)
{
  for(int i=0; i<array.Length; i++)
  Console.Write(array[i]+" ");
  Console.WriteLine();
}

int SearchNumbers(int[] myArray)
{ 
        int count = 0;
    int i = 1;
while (i < myArray.Length)
{
   count = count + myArray[i];
i = i+2;
}
return count;
}


Console.Write("Imput a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());

Console.Write("Imput a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Imput a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length,min, max);
WriteArray(myArray);

*/

/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
*/

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
  int[]array = new int [size];
  for (int i = 0; i < size; i++)
  array[i]=new Random().Next(minValue,maxValue+1);
  return array;
}

void WriteArray(int[]array)
{
  for(int i=0; i<array.Length; i++)
  Console.Write(array[i]+" ");
  Console.WriteLine();
}

int DifMaxMin(int [] myArray)
{
  int max= myArray[0];
  int min = myArray[0];
  for (int i = 0; i < myArray.Length; i++)
  {
    if (myArray[i] > max) max=myArray[i];
    else if (myArray[i] <min) min=myArray[i];
  }
int result = max-min;
return result;
}


Console.Write("Imput a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());

Console.Write("Imput a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Imput a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length,min, max);
WriteArray(myArray);

Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {DifMaxMin(myArray)}");