int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}



// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

/*
int number = ReadInt("Введите N: ");
Console.WriteLine(NaturalNumber(number));

int NaturalNumber(int n)
{
    if(n == 1)
        return 1;
    else
    {
        Console.Write(NaturalNumber(n - 1) + ", ");
    }
    return n;
}

void NaturalNumber(int n)
{
    if(n == 1)
        Console.Write(n + ", ");
    else
    {
        NaturalNumber(n - 1);
        Console.Write(n + ", ");
    }
}
*/

// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"


int m = ReadInt("Введите M: ");
int n = ReadInt("Введите N: ");
if (m < n)
{
    Console.WriteLine(Max_Min(m, n));
}
else
{
    Console.WriteLine(Min_Max(m, n));
}


int Max_Min(int m, int n)
{
    if(m == n)
        return n;
    else
    {
        Console.Write(Max_Min(m, n - 1) + ", ");
    }
    return n;
}

int Min_Max(int m, int n)
{
    if(m == n)
        return n;
    else
    {
        Console.Write(Min_Max(m, n + 1) + ", ");
    }
    return n;
}


/*
int start = ReadInt("Введите M: ");
int end = ReadInt("Введите N: ");
NaturalNumber(start, end);

void NaturalNumber(int m, int n)
{
    if (m < n)
    {
        Console.Write($"{m}, ");
        NaturalNumber(m + 1, n);
    }
    if (m > n)
    {
        Console.Write($"{m}, ");
        NaturalNumber(m - 1, n);
    }
    if (m == n)
    {
        Console.Write($"{m} ");
    }
}
*/

// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

/*
int number = ReadInt("Введите число: ");

int SumNmbers (int number)
{
   
    if (number == 0)
    {
        return number;
    }
    else
    {
        return number % 10 + SumNmbers(number / 10);
    }
}

int res = SumNmbers (number);
Console.Write (res);
*/

// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8


/*
int NumberOne = ReadInt("Введите первое число: ");
int NumberTwo = ReadInt("Введите второе число: ");


int Exponentiation (int number, int ExponentiationNumber)
{
    if (ExponentiationNumber == 0)
    {
        return 1;
    }
    else
    {
        return number * Exponentiation (number, ExponentiationNumber - 1);
    }
}

int res = Exponentiation (NumberOne, NumberTwo);
Console.Write (res);
*/
