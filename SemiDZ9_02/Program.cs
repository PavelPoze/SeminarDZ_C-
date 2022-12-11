/*
 Задача 66: Задайте значения M и N. Напишите программу, которая найдёт
  сумму натуральных элементов в промежутке от M до N.
 M = 1; N = 15 -> 120
 M = 4; N = 8. -> 30
 */
 
int m = ReadInt("Введите число M: ");
int n = ReadInt("Введите число N: ");
 
Console.Write(Sum(m - 1, n));
int Sum(int m, int n)   // функция сумма чисел от M до N
{
    int result = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        result = m + Sum(m, n);
        return result;
    }
}
 
int ReadInt(string message)         // ввод данных
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
