
/*
// Задача 2. Программа принимает на вход два числа и выдает, какое число большее, а какое меньшее.

int num1, num2;

Console.Write("Input the first integer number ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the second integer number ");
num2 = Convert.ToInt32(Console.ReadLine());

if(num1 == num2)
{
    Console.WriteLine("Error. Please, input two different integer numbers. Input the first integer number ");
    num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the second integer number ");
    num2 = Convert.ToInt32(Console.ReadLine());
}

if(num1 > num2)
    Console.Write(num1 + " больше " + num2 + " ");
else
    Console.Write(num2 + " больше " + num1 + " ");
*/

// Задача 4: Программа принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
int num1, num2, num3, max;

Console.Write("Input the first integer number ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the second integer number ");
num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the third integer number ");
num3 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
    max = num1;
else
    max = num2;
if(max < num3)
    max = num3;

Console.WriteLine("The maximum number is " + max );
*/

/*
// Задача 6: Программа на вход принимает число и выдаёт, является ли число чётным (делится ли оно на 
// два без остатка).

Console.Write("Input an integer number ");
int num = Convert.ToInt32(Console.ReadLine());

if(num % 2 == 0)
    Console.WriteLine(num + " is an even number.");
else
    Console.WriteLine(num + " is not an even number.");

*/

// Задача 8: Программа, которая на вход принимает число (N), а на выходе показывает все чётные числа 
// от 1 до N.
/*
Console.Write("Input positive integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = 2;

while (num < 2)
{
    Console.WriteLine("Error! Input a positive integer number greater than 1 ");
    num = Convert.ToInt32(Console.ReadLine());
}

while (current <= num)
{
    Console.Write(current + " ");
    current = current + 2;  
}
*/