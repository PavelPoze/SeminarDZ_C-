/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив,
 добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int rows = ReadInt("Введите число строк: ");     //зарашиваем количество срок (rows)
int columns = ReadInt("Введите число стоблбцов: ");   // запрашиваем количество столбцов (columns)
int depth = ReadInt("Введите число глубины: ");   // глубина(ширина) (depth)
int[,,] number = new int[rows, columns, depth ];

FillMatrix(number);
WriteMatrix(number);

void FillMatrix(int[, ,] array)     //заполнение двумерного массива
{
    int count = 10; // сщздание чисел от 10
    for (int i = 0; i < array.GetLength(0); i++)   // цикл для заполнения строк
    {
        for (int j = 0; j < array.GetLength(1); j++)   // цикл для заполнения стодбцов
        {
            for (int g = 0; g < array.GetLength(2); g++)  // цикл для ширины
            {
                 array[i, j, g] += count;
                count += 3;
            }
            
        }
    }
}

void WriteMatrix(int[, ,] array)    // вывод двумерного массива
{
    for (int i = 0; i < array.GetLength(0); i++)   // цикл для заполнения строк
    {
        for (int j = 0; j <array.GetLength(1); j++)   // цикл для заполнения стодбцов
        {
            Console.WriteLine();  // отступ
            for (int g = 0; g < array.GetLength(2); g++) // цикл для глубины
            {
                Console.Write($"{array[i, j, g]}({i},{j},{g}) "); // вывод элемента массива и его индекса
            } 
              
        }
        
    }
   
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}