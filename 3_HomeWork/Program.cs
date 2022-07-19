/*
// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

void IfPalindrome(int num)
{
    while(num <= 9999 || num > 99999)
    {
        Console.Write("Uncorrect input! Try again here: ");
        num = Convert.ToInt32(Console.ReadLine());
    }
    if(num / 10000 == num % 10 && num / 1000 % 10 == num % 100 / 10)
    {
        Console.WriteLine($"The number {num} is a palindrome.");
    }
    else Console.WriteLine($"The number {num} is not a palindrome.");
}

Console.Write("Input a positive integer five-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

IfPalindrome(number);
*/
//=====================

// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.



// Задача 23. Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.