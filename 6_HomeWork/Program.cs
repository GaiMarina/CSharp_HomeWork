

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

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

//=======================================
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
