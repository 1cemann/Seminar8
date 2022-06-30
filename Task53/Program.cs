//Задача 53: Задайте двумерный массив. Напишите программу, 
//которая поменяет местами первую и последнюю строку массива.


using System;
using static System.Console;
Clear();


int [,] array=new int[3,4];
FillArray(array);
PrintArray(array);
WriteLine();
ExChange(array);
PrintArray(array);


void ExChange(int [,] massive)
{
    int temp =0;
    for (int i = 0; i < massive.GetLength(1); i++)
    {
        temp =massive[0,i];
        massive[0,i]=massive[massive.GetLength(0)-1,i];
        massive[massive.GetLength(0)-1,i]=temp;
    }
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




