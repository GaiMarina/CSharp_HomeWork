/*
//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную 
//степень B.

long Exponentiation (int n1, int count)
{
    long result = 1;

    for (int i = 0; i < count; i++)

        result *= n1;

    return result;
}

Console.Write("Please, input the first integer number A: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Please, input the second positive integer number B: ");
int num2 = Convert.ToInt32(Console.ReadLine());

while(num2 < 1)
{
    Console.Write("Uncorrect input. Please, try again here: ");
    num2 = Convert.ToInt32(Console.ReadLine());
}
    
Console.WriteLine($" {num1} to the power of {num2} equals {Exponentiation(num1, num2)}");
*/
//===================================
/*
//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int SumOfDigits (int num)
{
    int sum = 0;

    while(num > 0)
    {
        sum += num % 10;  
        num = num / 10;   
    }
    return sum;
}

Console.Write("Please, input an integer number: ");
int number = Convert.ToInt32(Console.ReadLine());
int Number = number;
if(number < 0) number = number *(-1);

int result = SumOfDigits(number);
Console.WriteLine($"The sum of the digits in the number {Number} is {result}");
*/
//====================================

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] CreateRandomArray(int size)
{
    int[] newArray = new int[size]; 
    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next();
        
    return newArray; 
}   

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int[] FinalArray = CreateRandomArray(8);
PrintArray(FinalArray);