/*
Задача 41: Пользователь вводит с клавиатуры M чисел.
 Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/


Console.WriteLine ("Введите числа через запятую: ");
string output = Console.ReadLine()!;
string[] number = new string[output.Length]!;
int pass = 0;
for (int i = 0; i < number.Length; i++)
{
  if (output[i] == ',')
  {
    pass++;
  }
  else
  {
    number[pass] = number[pass]+$"{output[i]}";
  }
}
pass++;
int[] result = new int[pass];
PrintArray (result, number);
int find = 0;
for (int i = 0; i < pass; i++)
{
  if (result[i]>0)
  {
    find++;
  }
}
Console.WriteLine ("Чисел больше 0: " + find);

void PrintArray (int [] array, string [] string1)   //метод чтения массива
{
  for (int i = 0; i < array.Length; i++)
  {
  array[i] = Convert.ToInt32(string1[i]);
  Console.Write (array[i]+"  ");
  }
Console.WriteLine();
}


