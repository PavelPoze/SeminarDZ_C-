/*
Задача 56: Задайте прямоугольный двумерный массив.
 Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки 
с наименьшей суммой элементов: 1 строка
*/


int rows = ReadInt("Введите число строк: ");     //зарашиваем количество срок (rows)
int columns = ReadInt("Введите число стоблбцов: ");   /// запрашиваем количество столбцов (columns)
int[,] number = new int[rows, columns];

FillMatrix(number);
WriteMatrix(number);

int minSumRows = 0;
int sumRows = SumElemetsRows(number,0);

for (int i = 1; i <number.GetLength(0); i++)
{
    int tempSumRows = SumElemetsRows(number, i);
  if (sumRows > tempSumRows)
  {
    sumRows = tempSumRows;
    minSumRows = i;
  }
}
Console.WriteLine($"{minSumRows+1} строка с наименьщей суммой {sumRows} ");
int SumElemetsRows(int[,] array, int i)   // метод для суммирования элеметов сторки
{
  int sumRows = array[i,0];  // переменная сумма строки
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumRows += array[i,j];
  }
  return sumRows;
}

void FillMatrix(int[,] array)     //заполнение двумерного массива
{
    for (int i = 0; i < array.GetLength(0); i++)   // цикл для заполнения строк
    {
        for (int j = 0; j < array.GetLength(1); j++)   // цикл для заполнения стодбцов
        {
            array[i, j] = new Random().Next(1, 10);
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