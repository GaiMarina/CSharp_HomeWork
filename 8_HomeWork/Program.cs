/*
// Задача 54: Задать двумерный массив. Напиcать программу, которая упорядочит 
//            по убыванию элементы каждой строки двумерного массива.

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows,columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);
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


int[,] RowDescending(int[,] array)
{   
    for(int i = 0; i < array.GetLength(0); i++)
    {   
        for(int j = 0; j < array.GetLength(1) - 1; j++)
        {   
            int jMax = j;

            for(int m = j + 1; m < array.GetLength(1); m++)                    
                if(array[i,m] > array[i,jMax]) jMax = m;                    

            int temp = array[i,j];
            array[i,j] = array[i,jMax];
            array[i,jMax] = temp;
        }        
    }
    return array;    
}

Console.Write("Input the quantity of rows ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the quantity of columns ");
int col = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the min value of the elements ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the max value of the elements ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] array = CreateRandom2dArray(r, col, min, max);
Show2dArray(array);
Console.WriteLine();

Show2dArray(RowDescending(array));
*/
//==============================================
/*
//Задача 56: Задать прямоугольный двумерный массив. Написать программу, 
//           которая будет находить строку с наименьшей суммой элементов.
// Программа считает сумму элементов в каждой строке и выдаёт 
// номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows,columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);
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

// Строки в ответ вывожу считая с 1, а не с нуля как в случае с индексом.

int TheSmallestRowSum(int[,] array)
{   
    int minStr = 1;
    int minSum = 0;         

    for(int j = 0; j < array.GetLength(1); j++)
        minSum += array[0,j];
    
 
    for(int i = 1; i < array.GetLength(0); i++)
    {   
        int sum = 0;
        
        for(int j = 0; j < array.GetLength(1); j++)
            sum += array[i,j];
         
        if(sum < minSum)
        {
            minSum = sum;
            minStr = i + 1;
        }                 
    }  
    return minStr;     
}

Console.Write("Input the quantity of rows ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the quantity of columns ");
int col = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the min value of the elements ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the max value of the elements ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] array = CreateRandom2dArray(r, col, min, max);
Show2dArray(array);
Console.WriteLine();

Console.WriteLine($"The {TheSmallestRowSum(array)} line.");
*/
//=================================

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить 
//            произведение двух матриц.

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows,columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);
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

int[,] MatrixProduct(int[,] array, int[,] matrix)
{
    int[,] mProduct = new int[array.GetLength(0), array.GetLength(1)];

    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            mProduct[i,j] = array[i,j] * matrix[i,j];
        }
    }
    return mProduct;
}

Console.Write("Input the quantity of rows for both of the matrices ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the quantity of columns for both of the matrices ");
int col = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the min value of the elements for the first matrix ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the max value of the elements for the first matrix ");
int max = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the min value of the elements for the second matrix ");
int from = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the max value of the elements for the second matrix ");
int to = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] theFirstMatrix = CreateRandom2dArray(r, col, min, max);
Show2dArray(theFirstMatrix);
Console.WriteLine();

int[,] theSecondMatrix = CreateRandom2dArray(r, col, from, to);
Show2dArray(theSecondMatrix);
Console.WriteLine();

Show2dArray(MatrixProduct(theFirstMatrix, theSecondMatrix));
Console.WriteLine();

//================================

// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
/*
массив размером 2 x 2 x 2

12(0,0,0) 22(0,0,1)

45(1,0,0) 53(1,0,1)
*/

//================================

// Задача 62. Заполните спирально массив 4 на 4.
/*
Например, на выходе получается вот такой массив:

1 2 3 4

12 13 14 5

11 16 15 6

10 9 8 7
*/

