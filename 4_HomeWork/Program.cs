
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

//===================================
//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//452 -> 11

//82 -> 10

//9012 -> 12
//====================================
//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

//6, 1, 33 -> [6, 1, 33]

