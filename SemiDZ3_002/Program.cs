/* 
Задача 21: Напишите программу, которая принимает 
на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53        */

int x1 = ReadInt("Введите координаты Х1: ");
int y1 = ReadInt("Введите координаты B1: ");
int z1 = ReadInt("Введите координаты C1: ");

int x2 = ReadInt("Введите координаты Х2: ");
int y2 = ReadInt("Введите координаты B2: ");
int z2 = ReadInt("Введите координаты C1: ");

int a = x2 - x1;
int b = y2 - y1;
int c = z2 - z1;

double result = Math.Sqrt(a*a+b*b+c*c);

Console.WriteLine($"Расстояние равно = {result}");

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}



