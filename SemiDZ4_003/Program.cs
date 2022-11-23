/* Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
 Вывод сделать отдельным методом.
5 -> [1, 2, 5, 7, 19] 
3 -> [6, 1, 33]   */
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = number.ToString().Length;

int[] randomArray = new int[number];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(1,9);
    Console.Write(randomArray[i] + " ");
}



