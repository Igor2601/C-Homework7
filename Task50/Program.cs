// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1 7 -> такого числа в массиве нет
using System;
using static System.Console;
Clear();
int [,] array = GetArray(3, 4, 1, 9);
PrintArray(array);
WriteLine();
Write("i = ");
int i = int.Parse(ReadLine());
Write("j = ");
int j = int.Parse(ReadLine());
int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
    }
    return result;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]} ");
        }
        WriteLine();
    }
}
bool Position(int[,] array)
{
    if (i < array.GetLength(0) && j < array.GetLength(1))
    {
    Write($" -> {array[i, j]} ");
    return false;
    }
    else
    {
    Write($" -> такого числа в массиве нет");
    return false; 
    } 
    return true; 
}
if (Position(array))   
Write($" -> {array[i, j]}");