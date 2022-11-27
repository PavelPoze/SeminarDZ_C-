/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

int size = ReadInt("Введите длину массива:  ");       // просьба указать число
int[] number = new int[size];                         // создание массива с учетом введенного числа
FillArrayRandomNumbers(number, 100, 999);             //задали с помощью метода интервал чисел для массива
WriteArray(number);                                   // печать массива с учетов введеного числа
int count = 0;

for (int n = 0; n < number.Length; z++)               // определение принадлежности переменной n  к массиву
if (number[n] % 2 == 0)                               // проверка числа в массиве на четность
count++;                                              // переход к следующему числу
Console.WriteLine( count + " четных ");               // вывод исследования в консоль

void WriteArray(int[] array)                          // медот печати массива
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+ " ");
    }
    Console.WriteLine();
}

void FillArrayRandomNumbers(int[] array, int min, int max)  //заполнение массива
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
}

int ReadInt(string message)         // ввод данных
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}