/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07  */
int number = ReadInt("Введите желаемое значение стороны квадрата: ");
int[,] array = new int [number, number];
int i = 0;
int j = 0;
int temp = 1;
while (temp <= array.GetLength(0) * array.GetLength(1)) 
{
  array[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < array.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= array.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > array.GetLength(1) - 1)
    j--;
  else
    i--;
}
WriteMatrix(array); 

void WriteMatrix(int[,] array)    // вывод двумерного массива
{
    for (int i = 0; i < array.GetLength(0); i++)   // цикл для заполнения строк
    {
        for (int j = 0; j <array.GetLength(1); j++)   // цикл для заполнения стодбцов
        {
             if (array[i,j] < 10)  // если число менбше 10, то перед ним нужно поставть 0
             {   
                Console.Write("0" + array[i,j]);
                Console.Write(" "); // ставим пробел
             }
            else 
                Console.Write(array[i,j] + " " ); // число плюс пробел
        }
        Console.WriteLine();
        
    }
   
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
