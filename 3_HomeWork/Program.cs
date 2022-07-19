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
/*
// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.

double Length(double xa, double ya, double za, double xb, double yb, double zb)
{
    double length = Math.Sqrt((xb - xa) * (xb - xa) + (yb - ya) * (yb - ya) + (zb - za) * (zb - za));
    return length;
}

Console.WriteLine("Enter the x-coordinate of point A ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the y-coordinate of point A ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the z-coordinate of point A ");
int za = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the x-coordinate of point B ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the y-coordinate of point B ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the z-coordinate of point B ");
int zb = Convert.ToInt32(Console.ReadLine());

double result = Length(xa, ya, za, xb, yb, zb);
Console.WriteLine($"The distance between two points A and B is {result}.");
*/
//======================

// Задача 23. Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.

void Cubes(double num)
{
    int current = 1;
    while(current <= num)
    {
        Console.Write(current * current * current + " ");
        current ++;
    }
}

Console.Write("Input a positive integer number ");
int numberN = Convert.ToInt32(Console.ReadLine());

while(numberN < 1)
    {
    Console.Write("Uncorrect input! Try again here: ");
    numberN = Convert.ToInt32(Console.ReadLine());
    }

Cubes(numberN);