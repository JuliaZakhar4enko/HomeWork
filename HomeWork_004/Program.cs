//Урок 4. Функции

/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
/*
System.Console.Write("Imput a number: ");
int num = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Imput a power: ");
int n = Convert.ToInt32(Console.ReadLine());

int GetNumInPower(int num_n)
{
  int rez=1;
  for(int i=0; i<n; i++)
  {
   rez*=num;
  }
 return rez;
}

int result = GetNumInPower(num);
System.Console.WriteLine($"Number in a power {result}");
*/



/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
/*
int GetSummofNumbers(int num)
{
    int sum=0;
   while (num>0)
   {
   sum=num%10+sum;
    num=num/10;
      }
    return sum;
}
System.Console.Write("Imput a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = GetSummofNumbers(number);
System.Console.WriteLine($"Sum of numbers is {result}");
*/





/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
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

Console.Write("Imput a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());

Console.Write("Imput a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Imput a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length,min, max);
WriteArray(myArray);
*/




/*Задача 26 HARD Напишите программу, которая принимает на вход целое или дробное число и выдаёт количество цифр в числе.
456 -> 3
0 -> 1
89,126 -> 5
0,001->4
*/



double Round (double x)
{
  double rez_one = Math.Round(x);
  double rez_two = 0;
{
  double count_one = 0;
  while (rez_one > 0)
  {
    count_one++;
   rez_one = rez_one/10;
   
  }

   Console.WriteLine(rez_one);

}

{
  double count_two=0;
  while (rez_two%1>0)
  {
    rez_two=rez_two*10;
    count_two++;
  }
  System.Console.WriteLine(rez_two);
}
double z = rez_one +rez_two;
return z;
}

System.Console.WriteLine("Введите любое число: ");
double num = Convert.ToDouble(Console.ReadLine());

double result = Round(num);

Console.WriteLine($"Количество цифр в числе: {result}");

