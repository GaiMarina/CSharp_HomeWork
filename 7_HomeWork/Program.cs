
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными 
//числами.

//m = 3, n = 4.

//0,5 7 -2 -0,2

//1 -3,3 8 -9,9

//8 7,8 -7,1 9

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
/*
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

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

1,7 -> такого числа в массиве нет
*/
double[,] CreateDouble2dArray(int rows, int columns)
{
    double[,] newArray = new double[rows,columns];
    Random rand = new Random();

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {   
            newArray[i,j] = rand.Next() + rand.NextDouble();                   
        }
    }
 
    return newArray;
}

 void Show2dArray(double[,] array)
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

string FindElementValue(int row, int column, double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i = row; && j = column)
        }
        
    }
}


Console.Write("Input the number of rows ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the number of columns ");
int col = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input the number of row to find ");
int r = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input the number of column to find ");
int col = Convert.ToInt32(Console.ReadLine());

double[,] FinalArray = CreateDouble2dArray(r, col, min, max);
Show2dArray(FinalArray);

Console.WriteLine("Input the number of row to find ");
int r = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input the number of column to find ");
int col = Convert.ToInt32(Console.ReadLine());


//=================================

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
