/*
// Задача 64: Задать значения M и N. Написать программу, которая выведет 
//            все натуральные числа в промежутке от M до N.

void NaturalNumbers(int m, int n)
{
    if(m > n)
    {
        int temp = n;
        n = m;
        m = temp;
    }

    if(n != m)
        NaturalNumbers(m, n - 1);

    Console.Write(n + " ");      
}

Console.Write("Input the positive integer number M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the positive integer number N: ");
int n = Convert.ToInt32(Console.ReadLine());

NaturalNumbers(m, n);
*/
/*
string NaturalNumString(int m, int n)
{
    if(m <= n) return $"{m} " + NaturalNumString(m + 1, n);
        else return string.Empty;
}

Console.Write("Input the positive integer number M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the positive integer number N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(NaturalNumString(m,n));
*/
//========================
/*
// Задача 66: Задать значения M и N. Написать программу, которая найдёт 
//            сумму натуральных элементов в промежутке от M до N.

int NaturalSumRec(int m, int n)
{   

    if(m < 0) m *= -1;
    if(n < 0) n *= -1;
    if(m > n)
    {
        int temp = n;
        n = m;
        m = temp;
    }

    if(n != m) return n + NaturalSumRec(m, n - 1); 
    else return n; 
}

Console.Write("Input the positive integer number M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the positive integer number N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(NaturalSumRec(m,n));
*/
//==========================

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//            Даны два неотрицательных числа m и n.

//m = 2, n = 3 -> A(m,n) = 29

int AckermanFun(int m, int n)
{
    if(m == 0) return n + 1;
    if(m > 0 && n == 0) return AckermanFun(m - 1, 1);
    else return AckermanFun(m - 1, AckermanFun(m, n - 1));
}

Console.Write("Input the positive number m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the positive number n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(AckermanFun(m,n));
