/* 
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8

*/

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = num - 1;
while (num1 > 0)
{
    if (num1 % 2 == 0)
    {
        Console.WriteLine(num1);
        num1 = num1 -1;
    }
    else
    {
        num1 = num1 -1;
    }
}
