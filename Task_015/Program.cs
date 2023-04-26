/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/


 Console.WriteLine("Введите номер дня недели от 1 до 7");
int day = Convert.ToInt32(Console.ReadLine());
if(day >= 6 && day <=7)
{
    Console.WriteLine("Выходной");
}
else if(day > 0 && day < 6)
    Console.WriteLine("Рабочий");

