

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
int GreaterThanZero(int quan)
{   
    int count = 0;
    
    for(int i = 0; i < quan; i++)
    {
        Console.Write($"Input the {i + 1} element of {quan}: ");
            int num = Convert.ToInt32(Console.ReadLine());
        
        if(num > 0) 
            count ++;
    } 
return count;   
}   

Console.Write("Input the necessary quantity of numbers to enter: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"The quantity of numbers greater than zero is {GreaterThanZero(M)}");
*/
//=======================================

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

void IntersectionPoint(double k1, double k2, double b1, double b2)
{   
    double x;
    double y;

    x = (b2 - b1) / (k1 - k2);
    y = k2  * x + b2;

    Console.Write($"An intersection point is ({x};{y})");
    Console.WriteLine();
}

Console.Write($"Input the first value k1: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write($"Input the first value k2: ");
double b = Convert.ToDouble(Console.ReadLine());

Console.Write($"Input the first value b1: ");
double c = Convert.ToDouble(Console.ReadLine());

Console.Write($"Input the first value b2: ");
double d = Convert.ToDouble(Console.ReadLine());

IntersectionPoint(a, b, c, d);


//Если точка M, является точкой пересечения двух прямых, то она должна принадлежать этим прямым, а ее координаты удовлетворять уравнениям этих прямых.