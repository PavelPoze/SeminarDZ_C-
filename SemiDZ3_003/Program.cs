 /*
Задача 23: Напишите программу,
 которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 4, 9. 
5 -> 1, 8, 27, 64, 125

3 -> 1, 8, 27 
5 -> 1, 8, 27, 64, 125    */


int number = ReadInt("Введите число: ");
 int count = 1;

 while (count <= number)
 {
    /*Console.Write($"{count*count} "); 
    count ++;*/
     Console.Write(count*count*count++ + " ");  // сразу обозначает переход на следущий уровень
 }
 Console.WriteLine();

 int ReadInt(string message)
 {
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
 }

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