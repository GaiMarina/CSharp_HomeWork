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
/*
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
*/
//=============================
/*
// Задача 19 через массив c проверкой и двумя методами.

string IfPalindrome(string Number)
{
    string result = String.Empty;
    
    if(Number[0] == Number[4] && Number[1] == Number[3])
        result = result + $"The number is a palindrome.";
    else result = result + $"The number is not a palindrome.";
    return result;
}

int IfFiveDigitNumber()
{
    
    Console.Write("Please, input a positive five-digit integer number ");
    int number = Convert.ToInt32(Console.ReadLine());
    while(number <= 9999 || number > 99999)
    {
        Console.Write("Uncorrect input! Try again here: ");
        number = Convert.ToInt32(Console.ReadLine());
    }
    return number;
}    

int N = IfFiveDigitNumber();

string Result = Convert.ToString(N);

string Final = IfPalindrome(Result);
Console.WriteLine(Final);
*/
//=======================
/*
//Задача 19 без проверки через массив.

string IfPalindrome(string Number)
{
    string result = String.Empty;
    
    if(Number[0] == Number[4] && Number[1] == Number[3])
        result = result + $"The number is a palindrome.";
    else result = result + $"The number is not a palindrome.";
    return result;
}
Console.Write("Please, input a positive five-digit integer number ");
string number = Convert.ToString(Convert.ToInt32(Console.ReadLine()));
string result = IfPalindrome(number);
Console.WriteLine(result);
*/
//===============================
/*
// Задача 19 через массив с проверкой и одним методом.

string IfPalindrome(string Number)
{
    string result = String.Empty;
    
    if(Number[0] == Number[4] && Number[1] == Number[3])
        result = result + $"The number is a palindrome.";
    else result = result + $"The number is not a palindrome.";
    return result;
}

Console.Write("Please, input a positive five-digit integer number ");
int number = Convert.ToInt32(Console.ReadLine());

while(number <= 9999 || number > 99999)
{
    Console.Write("Uncorrect input! Try again here: ");
    number = Convert.ToInt32(Console.ReadLine());
}

string Result = Convert.ToString(number);

string Final = IfPalindrome(Result);
Console.WriteLine(Final);
*/
//=======================
/*
//Задача 19 через разворот массива с числом занимающим не более 32 бит.

string ReverseOrder(string Number)
{
    string line = String.Empty;
    int count = Number.Length - 1;

    for(int i = count; i >= 0; i--)
        line = line + $"{Number[i]}";
    return line;
}
    
Console.Write("Please, input a positive integer number ");
string number = Convert.ToString(Convert.ToInt32(Console.ReadLine()));
string temp = number;
string result = ReverseOrder(number);
if(result == temp)
    Console.WriteLine("The number is a palindrome.");
else
    Console.WriteLine("The number is not a palindrome.");
*/

