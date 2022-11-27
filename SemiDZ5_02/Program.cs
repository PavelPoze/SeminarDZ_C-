/*Задача 36: 
Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0 */


int size = ReadInt("задайте массив ");                     // начало работы  
int[] number = new int[size];                              // создание массива от указанного числа числа
FillArrayRandomNumbers(number, 1,10);                      // определение интевала случайных числел массива
WriteArray(number);                                        // печать массива в консоль
int result = 0;                                            // искомое значение
for ( int i = 0; i < number.Length; i++)                   // определение идекса числа в массиве
{
    if ( i % 2 != 0)                                       // проверка индекса на четность
    {
        result += number[i];                               // запись результата и перехода к следующему
    }
}
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