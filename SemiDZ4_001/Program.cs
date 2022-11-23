/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/


Console.WriteLine("введите число 1 ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число 2 ");
int numberB = Convert.ToInt32(Console.ReadLine());
int sum = numberA;
int i = 1;
while (i < numberB)
{
    sum = sum * numberA;
    i++;
}
Console.WriteLine(sum);