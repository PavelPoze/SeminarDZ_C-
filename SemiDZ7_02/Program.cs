/* Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
Во вводе первая цифра - номер строки, вторая - столбца. Цифры не больше 9.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет
*/

int m = ReadInt("Введите число строк: ");     
int n = ReadInt("Введите число стоблбцов: ");
int[,] number = new int[m,n];   // создаем двумерный массив исходя из введенных данных
FillMatrix(number);
WriteMatrix(number);
if (m < number.GetLength(0) && n < number.GetLength(1))
{
    Console.WriteLine(number[m,n]);
}
else
{
    Console.WriteLine($"{m}{n} : такого элемента нет");
}

void FillMatrix(int[,] array)     //заполнение двумерного массива
{
    for (int i = 0; i < array.GetLength(0); i++)   // цикл для заполнения строк
    {
        for (int j = 0; j < array.GetLength(1); j++)   // цикл для заполнения стодбцов
        {
            array[i, j] = new Random().Next(1, 100);
        }
    }
}
void WriteMatrix(int[,] array)    // вывод двумерного массива
{
    for (int i = 0; i < array.GetLength(0); i++)   // цикл для заполнения строк
    {
        for (int j = 0; j <array.GetLength(1); j++)   // цикл для заполнения стодбцов
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
