//Задача 57: Составить частотный словарь элементов двумерного массива. 
//Частотный словарь содержит информацию о том, сколько раз встречается 
//элемент входных данных.
//Если набор данных — таблица:
//1, 2, 3
//4, 6, 1
//2, 1, 6
//1 встречается 3 раза
//2 встречается 2 раз
//3 встречается 1 раз
//4 встречается 1 раз
//6 встречается 2 раза

using System;
using static System.Console;
using System.Linq;
Clear();


int [,] array=new int[4,4];
FillArray(array);
PrintArray(array);
WriteLine();
int [] arr2=Array(array);

arr2=arr2.OrderBy(x=>x).ToArray();
int element=arr2[0];
int count=1;
for (int l = 1; l < arr2.Length; l++)
{
    if (arr2[l]==element) count++;
    else
    {
    WriteLine($"Element {element} - {count}");
    count = 1;
    element=arr2[l];
    }
} 
WriteLine($"Element {element} - {count}");   



int[] Array(int[,] newarr)
{
    int[] result = new int[newarr.GetLength(0)*newarr.GetLength(1)];
    int count =0;
    for (int i = 0; i < newarr.GetLength(0); i++)
    {
        for (int j = 0; j < newarr.GetLength(1); j++)
        {
            result[count]= newarr[i,j];
            count++;
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
