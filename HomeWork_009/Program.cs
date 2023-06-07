/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

/*
string PrintNum(int num)
{
    if (num == 1) return "1";  // тумблер выключения
                              //return num + PrintNum(num-1);   // и суммирование и уменьшение счетчика на 1

    return num+ ","+ PrintNum(num - 1);
}

Console.Clear();
System.Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Натуральные числа в промежутке от 1 до {num}: ");
System.Console.WriteLine(PrintNum(num));
*/



/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
/*
int SumNum(int num1, int num2)
{
    if (num1>num2) return num1>num2 ? num1 + SumNum (num2, num1-1) : num1;
   else return num2>num1 ? num2 +SumNum(num2-1, num1) : num2;
}
Console.Clear();
System.Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Сумма натуральных чисел от {num1} до {num2} = {SumNum(num1, num2)}");
*/



/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

/*
int Accermann(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return Accermann(m - 1, 1);
    return Accermann(m - 1, Accermann(m, n - 1));
}
Console.WriteLine(Accermann(3, 2));
*/