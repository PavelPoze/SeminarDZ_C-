/* 
Задача 2: Напишите программу, которая на вход принимает 
два числа и выдает, какое число большее, а какое меньшее.

a = 5; b = 7 ->  max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3


*/

Console.WriteLine(" Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int min = 0;
int max = 0;
if (number1 > max) max = number1;
if (number2 < min) min = number2;
if (number1 > number2)
{
    Console.Write("max = ");
    Console.WriteLine(max = number1);
    Console.Write("min = ");
    Console.WriteLine(min = number2);
}
else
{
    Console.Write("max = ");
    Console.WriteLine(max = number2);
    Console.Write("min = ");
    Console.WriteLine(min = number1);
}
