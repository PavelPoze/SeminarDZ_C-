/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
Console.WriteLine("Число столбцов первой матрицы и число строк второй должны быть одинаковые! ");
int m= ReadInt("Введите число строк 1-ой матрицы: ");     //зарашиваем количество срок (rows)
int n = ReadInt("Введите число столбцов 1-ой матрицы и число строк 2-й матрицы: ");   /// запрашиваем количество столбцов (columns)
int k = ReadInt("Введите число столбцов 2-ой матрицы: ");   /// запрашиваем количество столбцов (columns)
int[,] matrix = new int[m, n];
int[,] matrix2 = new int[n, k];
//Произведение матрицы A размера m × n и матрицы B размера n × k — это матрица C размера m × k.
int[,] resultMatrix = new int[m,k];
FillMatrix(matrix);
WriteMatrix(matrix);
FillMatrix(matrix2);
WriteMatrix(matrix2);
MultiMatrix(matrix, matrix2, resultMatrix);
Console.WriteLine("Произведение матриц: ");
WriteMatrix(resultMatrix);

void MultiMatrix(int[,] matrix, int[,] matrix2, int[,] resultMatrix) //метод перемножения матриц
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int f = 0; f < matrix.GetLength(1); f++) // новая переменная одинаковая для столца первой и сроки вротой
      {
        sum += matrix[i,f] * matrix2[f,j]; // умножнние эелента  строки м1 на элемент столбца м2
      }
      resultMatrix[i,j] = sum;
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
