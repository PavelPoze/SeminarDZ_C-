/* Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
int m = ReadInt("Введите число строк: ");     //зарашиваем количество срок (rows)
int n = ReadInt("Введите число стоблбцов: ");   /// запрашиваем количество столбцов (columns)
double[,] number = new double[m, n];
FillMatrixArrayRandomNumbers(number);
WriteMatrix(number);

void FillMatrixArrayRandomNumbers(double[,] array)     //заполнение двумерного массива
{
    for (int i = 0; i < array.GetLength(0); i++)   // цикл для заполнения строк
    {
        for (int j = 0; j < array.GetLength(1); j++)   // цикл для заполнения стодбцов
        {
            int randomNumberv = new Random().Next(10,100);  // задание интервала для чисел
            array[i, j] = Convert.ToDouble(randomNumberv) / 10;  // задание значения после запятой, сейчас два знака
        }
    }
}

void WriteMatrix(double[,] array)    // вывод двумерного массива
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