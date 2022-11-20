/* 
Задача 19: Напишите программу, которая принимает 
на вход пятизначное число и проверяет, является ли 
оно палиндромом.

14212 -> нет
23432 -> да
12821 -> да         */
/*
int number = ReadInt("Введите число: ");


int ReadInt(string message)

{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
*/

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = number.ToString().Length;
string str = number.ToString();
Console.WriteLine(count);
if (count == 5)
{
    if (str[0] == str[4] && str[1] == str[3])
    {
        Console.WriteLine((number) + " - Палиндром");
    }
    else
    {
        Console.WriteLine((number) + " - НЕ палиндром");
    }
}
else
{
    Console.WriteLine((number) + "- не является пятизначным");
}
