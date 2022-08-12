/*
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными 
//числами.

double[,] CreateDouble2dArray(int rows, int columns, int minValue, int maxValue)
{
    double[,] newArray = new double[rows,columns];
    Random rand = new Random();

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {   
            newArray[i,j] = rand.Next(minValue, maxValue + 1) + rand.NextDouble();                   
        }
    }
 
    return newArray;
}

 void Show2dArray(double[,] array)
 {
    for(int i = 0; i < array.GetLength(0); i++) //Длина по умолчанию с 0.
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
 }

Console.Write("Input the number of rows ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the number of columns ");
int col = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the min value of the elements ");

int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the max value of the elements ");
int max = Convert.ToInt32(Console.ReadLine());

double[,] FinalArray = CreateDouble2dArray(r, col, min, max);
Show2dArray(FinalArray);
*/
//=================================
/*
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] CreateRandom2dArray(int rows, int columns) 
{
    int[,] newArray = new int[rows,columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(1,10);
        }
    }
    
    return newArray;
}

void Show2dArray(int[,] array)
 {
    for(int i = 0; i < array.GetLength(0); i++) 
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
 }

void FindElementValue(int[,] array, int row, int column)
{
    if(row < array.GetLength(0) && column < array.GetLength(1))
        Console.WriteLine($"The corresponding element is {array[row, column]}");
    else    
        Console.WriteLine("The element is out of matrix.");        
}

Console.Write("Input the quantity of rows ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the quantity of columns ");
int col = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the number of row to find ");
int hor = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the number of column to find ");
int vert = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

int[,] newArray = CreateRandom2dArray(r, col);
Show2dArray(newArray);
Console.WriteLine();
FindElementValue(newArray, hor, vert);
*/
//=================================

// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
/*Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

int[,] CreateRandom2dArray(int rows, int columns) 
{
    int[,] newArray = new int[rows,columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(1,10);
        }
    }
    
    return newArray;
}

void Show2dArray(int[,] array)
 {
    for(int i = 0; i < array.GetLength(0); i++) 
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
 }

void ArithmeticalMean(int[,] array)
{          
    for(int j = 0; j < array.GetLength(1); j++)
    {   
        double sum = 0;
        double count = 0;
        
        for(int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i,j];
            count++;            
        }
        Console.Write(sum / count + "; ");
    }    
}

Console.Write("Input the quantity of rows ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the quantity of columns ");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] newArray = CreateRandom2dArray(r, col);
Show2dArray(newArray);
Console.WriteLine();

ArithmeticalMean(newArray);
Console.WriteLine();