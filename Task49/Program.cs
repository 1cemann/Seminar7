//**Задача 49:** Задайте двумерный массив. Найдите элементы, 
//у которых оба индекса чётные, и замените эти элементы на их квадраты.

//Например, изначально массив выглядел вот так:

//1 4 7 2
//5 9 2 3
//8 4 2 4
using System;
using static System.Console;
Clear();


Write("Введите размер матрецы через пробел ");
string[] sizeS = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
int rows = int.Parse(sizeS[0]);
int columns = int.Parse(sizeS[1]);
int[,] ar = GetRandomArray(rows, columns);
PrintArray(ar);
WriteLine();
int[,] arr = GetChangeArray(ar);
PrintArray(arr);

int[,] GetRandomArray(int row, int column)
{
   int[,] result = new int[row, column];
   for (int i = 0; i < result.GetLength(0); i++)
   {
      for (int j = 0; j < result.GetLength(1); j++)
      {
         result[i, j] = new Random().Next(0, 10);
      }
   }
   return result;
}

int[,] GetChangeArray(int[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         if (i % 2 == 0 && j % 2 == 0) array[i, j] *= array[i, j];
      }
   }
   return array;
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

