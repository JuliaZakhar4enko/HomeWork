/* Задача необязательная 1: на входе целое или вещественное число, надо удалить вторую цифру слева этого числа.

145 -> 15
1 -> нет
567,123 -> 57,123
*/


Console.WriteLine("введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 0;
int i = num;
while (i > 0)
{
    count++;
    i = i / 10;
}
int res = num / Convert.ToInt32(Math.Pow(10, count - 1))*Convert.ToInt32(Math.Pow(10, count - 2)) + num % (Convert.ToInt32(Math.Pow(10, count - 2)));

Console.WriteLine(res);



