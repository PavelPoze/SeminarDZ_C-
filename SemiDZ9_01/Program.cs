
/*
 Задача 64: Задайте значения N. Напишите программу, 
 которая выведет все натуральные числа в промежутке от N до 1.
 N = 5. -> "5, 4, 3, 2, 1"
 N = 8. -> "8, 7, 6, 5, 4, 3, 2, 1"
 */
int number = ReadInt("Введите N: ");
int count = 1;
NaturalNumbers(number, count);
 
void NaturalNumbers(int n, int count)
{
    if (count > n)
    {
        return;
    }
    else
    {
        NaturalNumbers(n, count + 1);
        Console.Write(count + " ");
    }
}
int ReadInt(string message)         // ввод данных
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}