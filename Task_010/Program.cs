﻿/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Через строку решать нельзя.

456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Введите целое трехзначное число ");
int num = Convert.ToInt32(Console.ReadLine());
int result = num / 10;
Console.WriteLine(result %10);
