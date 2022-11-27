/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76    */



int size = ReadInt("задайте массив ");                     // начало работы  
int[] number = new int[size];                              // создание массива от указанного числа числа

FillArrayRandomNumbers(number, 1,10);                      // определение интевала случайных числел массива
WriteArray(number);                                        // печать массива в консоль
int max = number[0];                                       // создание максимальной переменной
int min = number[0];                                       // сздание минимальной переменной                        

for (int i = 0; i < number.Length; i++)
{
    if (max < number[i])
    {
        max = number[i];
    }
     if (min > number[i])
    {
        min = number[i];
    }
}
int result = max - min;              // искомое значение
Console.WriteLine(result);
void WriteArray(int[] array)                                 //  создние массива
{
    for ( int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
void FillArrayRandomNumbers(int[] array, int min, int max)   // заполенеие массива
{
    for (int i = 0; i < array.Length; i++)
    { 
        array[i] = new Random().Next(min, max+1);
    }

}
int ReadInt(string message)                                  // ввод числа
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}