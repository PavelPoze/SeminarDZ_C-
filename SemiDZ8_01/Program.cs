/*Задача 54: Задайте двумерный массив. Напишите программу,
 которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

int rows = ReadInt("Введите число строк: ");     //зарашиваем количество срок (rows)
int columns = ReadInt("Введите число стоблбцов: ");   /// запрашиваем количество столбцов (columns)
int[,] number = new int[rows, columns]; // создание массива исходя из введеного значения
                                        // строк и столбцов

FillMatrix(number);   //  заполнение двумерного массива случайными числами
WriteMatrix(number); // вывод 
SortArray(number);
WriteMatrix(number);

void SortArray(int[,] array) //метод сортировки  двумерного массива
{
  for (int i = 0; i < array.GetLength(0); i++)  // проход  по стркам
  {
    for (int j = 0; j < array.GetLength(1); j++) // проход по столбцам
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++) // переменная
      {
        if (array[i, k] < array[i, k + 1]) // если элемент массива меньше следующего за ним элемента
        {
          int temp = array[i, k + 1]; // в перем. temp записываем занчение меншего эл-та
          array[i, k + 1] = array[i, k]; // меняем местами меньшее значение с текущим
          array[i, k] = temp; // записываем в текущий значение из перем.
        }
      }
    }
  }
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






