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
/*
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
*/
//================================
/*
// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.

int[,,] VariousDigits3dArray(int rows, int columns, int layers)
{
    int[,,] array = new int[rows, columns, layers]; 
    array[0,0,0] = 9;
    int temp = array[0,0,0];
   
    for(int i = 0; i < rows; i++)
    {   
        for(int j = 0; j < columns; j++)
        {
            for(int m = 0; m < layers; m++)
            {   
                array[i,j,m] = temp + 1;
                temp = array[i,j,m];
            }
        }
    }
    return array;
}

void Show3DArrayAndIndex(int[,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int m = 0; m < array.GetLength(2); m++)
            {
                Console.Write($"{array[i,j,m]}({i},{j},{m}) ");                
            }
            Console.WriteLine();
        }

    }
}

Console.Write("Input the quantity of rows ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the quantity of columns ");
int col = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the quantity of rows ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,,] threeDArray = VariousDigits3dArray(r, col, m);
Show3DArrayAndIndex(threeDArray);
*/
//================================

// Задача 62. Заполните спирально массив 4 на 4.

void PrintSpiral(int[,] spiral) 
{
   for(int i = 0; i < spiral.GetLength(0); i++) 
    {
        for(int j = 0; j < spiral.GetLength(1); j++)
        {
            Console.Write($"{spiral[i,j]} ");            
        }
        Console.WriteLine();
    }
}

int[,] spiral;

void FulfillSpiral(int rows, int columns)
{       
    spiral[0,0] = 1;
    int j = 0;
    int i = 0;
    
    for(int k = 0; k < (rows + 1) / 2; k++)
    {

    for(j += 1; j < columns-k; j++) //1
        if(spiral[i, j] == 0)
            spiral[i,j] = spiral[i,j - 1] + 1;
    j--;
 
    for(i += 1; i < rows-k; i++)  //2
        if(spiral[i, j] == 0)
            spiral[i,j] = spiral[i - 1,j] + 1;
    i--;
 
    for(j -= 1; j > k-1; j--)  //3
        if(spiral[i, j] == 0)
             spiral[i,j] = spiral[i,j + 1] + 1;
    j++;

    for(i -= 1; i > k; i--)  //4
        if(spiral[i, j] == 0)
            spiral[i,j] = spiral[i + 1,j] + 1;
    i++;
    }
}

Console.Write("Input the quantity for rows and columns of the spiral ");
int r = Convert.ToInt32(Console.ReadLine());
int col = r;

spiral = new int[r,col];
FulfillSpiral(r, col);
PrintSpiral(spiral);
