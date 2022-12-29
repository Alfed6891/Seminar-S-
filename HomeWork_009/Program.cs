int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}


// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


int addnumber = ReadInt("Введите число: ");

void NumberCounter (int number)
{
    if (number == 0) 
    return;
    Console.Write(number + " ");
    NumberCounter (number - 1);
   
}
NumberCounter(addnumber);



// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int m = ReadInt("Введите стартовое число: ");
int n = ReadInt("Введите финишное число: ");
int sum = SumNumbers (m - 1,n);
Console.WriteLine($"Сумма чисел в диапазоне: {sum}");

int SumNumbers (int firstnumber, int lastnumber)
{
    int sum = 0;
    if (firstnumber == lastnumber)
    return 0;
    else
    {
        firstnumber++;
        sum = firstnumber + SumNumbers(firstnumber,lastnumber);
    }
    return sum;
}



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int numberOne = ReadInt("Введите первое число: ");
int numberTwo = ReadInt("Введите второе число: ");

Console.WriteLine(Akkerman(numberOne, numberTwo));

int Akkerman (int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return Akkerman(m - 1, 1);
    }
    else // m > 0, n > 0
    {
        return (Akkerman (m - 1, Akkerman(m, n - 1)));
    }
}