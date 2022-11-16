/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
*/

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = number.ToString().Length;// Определил кол-во цифр в числе.

if (count < 3)
{
    Console.WriteLine("Цифры нет");
}
else
{
    string str = number.ToString(); //определяет цифру числа от индекса числа
    Console.WriteLine(str[2]);
   
}
