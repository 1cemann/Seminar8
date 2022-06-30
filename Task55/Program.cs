//Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки
// на столбцы. В случае, если это невозможно, программа должна вывести сообщение
// для пользователя.

using System;
using static System.Console;
Clear();

int [,] array=new int[4,4];  // Если массив будет неравномерный то выдаст ошибку
FillArray(array);
PrintArray(array);
WriteLine();
if(array.GetLength(0) == array.GetLength(1))
{
   PrintArray(Change(array));
}
else WriteLine("Eror");
WriteLine();
PrintArray(Change2(array));

int[,] Change2(int [,] massive)// ВТорой способ работы внутри данного массива
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = i; j < massive.GetLength(1); j++)
        {
            int temp=massive[i,j];
            massive[i,j]=massive[j,i];
            massive[j,i]= temp;
        }
    }
    return massive;
}



int[,] Change(int [,] massive)// Метод с созданием новго массива
{
    int[,] result= new int[massive.GetLength(0),massive.GetLength(0)];
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(0); j++)
        {
            result[j,i]=massive[i,j];
        }
    }
    return result;
}



void FillArray(int[,] newarr)
{
    for (int i = 0; i < newarr.GetLength(0); i++)
    {
        for (int j = 0; j < newarr.GetLength(1); j++)
        {
            newarr[i,j]= new Random().Next(0,10);
        }
    }
}


void PrintArray(int[,] newarr)
{
    for (int i = 0; i < newarr.GetLength(0); i++)
    {
        for (int j = 0; j < newarr.GetLength(1); j++)
        {
            Write($"{newarr[i,j]} ");
        }
        WriteLine();
    }
}
