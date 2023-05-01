/* Task 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Через строку решать нельзя.

14212 -> нет

12821 -> да

23432 -> да
*/

Console.WriteLine("Введите пятизначное число: ");
int count = Convert.ToInt32(Console.ReadLine());

if (count/1000 == count % 10 * 10 + count / 10 % 10)
{
    Console.WriteLine($"Число {count}  является палиндромом");
}
else 
{
    Console.WriteLine($"Число {count} не является палиндромом");
}


/* Task 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

/*double Distance (int x1, int y1, int z1, int x2, int y2, int z2)
{
   return Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
}

Console.Write("Введите x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Math.Round(Distance (x1, y1, z1, x2, y2, z2), 2));
*/




/* Task 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

/*void Kub (int N)
{
    int count = 1;
    while (count <= N)
    {
        Console.WriteLine(count + " - " + count*count*count);
        count++;
    }
}
Console.WriteLine("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
Kub(N);

*/
