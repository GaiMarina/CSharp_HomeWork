
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
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

//==============================================

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
//=================================

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
Например, заданы 2 массива:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

и

1 5 8 5

4 9 4 2

7 2 2 6

2 3 4 7

Их произведение будет равно следующему массиву:

1 20 56 10

20 81 8 6

56 8 4 24

10 6 24 49
*/
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

