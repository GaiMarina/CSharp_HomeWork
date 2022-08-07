﻿
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] Create3DigitsArray(int size)
{
    int[] NewArray = new int[size];

    for(int i = 0; i < size; i++)
    NewArray[i] = new Random().Next(100,1000);

    return NewArray;
}
void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int CountPositiveNumbers(int[] array)
{
    int count = 0;

    for(int i = 0; i < array.Length; i++)
    if(array[i] % 2 == 0)
    count++;

    return count;
}

Console.Write("Input the size of an array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] newArray = Create3DigitsArray(size);
PrintArray(newArray);
Console.WriteLine($"The quantity of positive numbers is {CountPositiveNumbers(newArray)}");
*/
//=============================
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] NewArray = new int[size];

    for(int i = 0; i < size; i++)
    NewArray[i] = new Random().Next(minValue,maxValue + 1);

    return NewArray;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

long SumOfOddElements(int[] array)
{
    long sum = 0;

    for(int i = 1; i < array.Length; i += 2)
        sum += array[i];

    return sum;
}

Console.Write("Input the size of an array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the min value of an element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the max value of an element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] NewArray = CreateRandomArray(size, min, max);
PrintArray(NewArray);

Console.WriteLine($"The sum of elements with negative indexes is {SumOfOddElements(NewArray)}");
*/
//==============================

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76
