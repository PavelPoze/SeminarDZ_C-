/*
 Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
 Даны два неотрицательных числа m и n.
 m = 2, n = 3 -> A(m,n) = 9
 m = 3, n = 2 -> A(m,n) = 29
 */
 
int m = ReadInt("Введите число m: ");
int n = ReadInt("Введите число n: ");
Console.Write(Akkerman(m, n)); 
 
int Akkerman(int m, int n)   // функция Аккермана
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}
 
int ReadInt(string message)         // ввод данных
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
