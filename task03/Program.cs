﻿/*
 Напишите программу которая на вход принимает число (N),
а на выходе показывает все целые числа в промежутке от -N до N.

4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4,"
2 -> "-2, -1, 0, 1, 2"
*/
Console.WriteLine("Введите число : ");
int numberA = Convert.ToInt32(Console.ReadLine());
int start = numberA * -1;
while (start <= numberA)
{
    Console.Write(start+" ");
    start = start + 1;
}

