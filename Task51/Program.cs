//**Задача 51:** Задайте двумерный массив. Найдите сумму элементов,
//находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
using System;
using static System.Console;
Clear();


Write("Введите число строк массива  ");
int m=int.Parse(ReadLine());
Write("Введите число столбцов массива  ");
int n=int.Parse(ReadLine());
int[,] arrayi=FillArrayMPLUSN(m,n);
PrintArray(arrayi);
WriteLine();

WriteLine($"{GerSumDiag(arrayi)}");

int GerSumDiag(int[,] array)
{   
    int im=0,sum=0;
    if(array.GetLength(0)>array.GetLength(1)) im=array.GetLength(1); else im=array.GetLength(0);
    for(int i=0;i<im;i++)
    {
        sum+=array[i,i];
    }
    return sum;
}

int[,] GetCHET(int[,] array)
{
   for(int i=0;i<array.GetLength(0);i+=2)
    {   
        
        for(int j=0;j<array.GetLength(1);j+=2)
        {
            array[i,j]*=array[i,j];
        }
    }
    return array; 
}

int[,] FillArrayMPLUSN(int rows,int len)
{
    int[,] array=new int[rows,len];
    for(int i=0;i<array.GetLength(0);i++)
    {
        for(int j=0;j<array.GetLength(1);j++)
        {
            array[i,j]=new Random().Next(1,10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for(int i=0;i<array.GetLength(0);i++)
    {
        for(int j=0;j<array.GetLength(1);j++)
        {
           Write($" {array[i,j]}");
        }
        WriteLine();
    }
}


// ЧЕРЕЗ БИИБЛОТЕКУ System.Linq 

// int[] array=ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries)
//.Select(x=>int.Parse(x)).OrderBy(x=>x).ToArray();
// МЕТОД СОРТИРОКИ МАССИВА СРАЗУ ИЗ СТРОКИ