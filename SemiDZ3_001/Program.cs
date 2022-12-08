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

/*

int number = 12321;

int first = number / 10000;
int second = number / 1000 % 10;
int third = number / 100 % 10;
int four = number / 10 % 10;
int fifth = number % 10;

if(first == fifth && second == four)
{
Console.WriteLine("Да");
}
else
{
Console.WriteLine("Нет");
}


*/