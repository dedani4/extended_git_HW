﻿/*Задача 64: Напишите программу, которая реализует 
рекурсивный метод вывода всех натуральных числел в промежутке от N до 1.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

using static System.Console;
Clear();

Write("Enter a number: ");
int A = Convert.ToInt32(ReadLine());

NaturalNumber(A);

void NaturalNumber(int A)
{
    if (A > 0)
    {
        if (A != 1) Write($"{A}, ");
        else Write($"{A}");
        NaturalNumber(A - 1);
    }
}