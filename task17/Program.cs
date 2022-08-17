﻿// Задача 17. Напишите программу, которая принимает на 
// вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер 
// четверти плоскости, в которой находится эта точка.

Console.WriteLine ("Введите координату x");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите координату y");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine("Точка находится в первой координатной плоскости");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("Точка находится во второй координатной плоскости");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("Точка находится в третьей координатной плоскости");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("Точка находится в четвёртой координатной плоскости");
}
else
{
    Console.WriteLine("Невозможно определить координаты точки");
}