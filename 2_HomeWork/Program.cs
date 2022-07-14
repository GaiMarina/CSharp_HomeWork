/*
// Зад. 10: Программа принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.

int TheSecondDigit(int num)
{
    int dig = num / 10 % 10;

    return dig;
}

Console.Write("Input a three-digit integer number: ");
int number = Convert.ToInt32(Console.ReadLine());

int digit = TheSecondDigit(number);

Console.WriteLine($"The second digit is {digit}");
*/

// Зад. 13: Программа выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

int TheThirdDigit(int num)
{
    int d = num % 10;

    return d;
}

int ThirdDigitNumber(int n)
{
    while(n > 999)
    n /= 10;

    return n;
}

Console.Write("Input an integer number ");
int number = Convert.ToInt32(Console.ReadLine());

int tdn = ThirdDigitNumber(number);

if(tdn > 99)
{
    int dig = TheThirdDigit(tdn);
    Console.WriteLine($"The third digit is {dig}");
}
else
    Console.WriteLine($"The third digit is missing.");
    





// Зад. 15: Программа принимает на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.

