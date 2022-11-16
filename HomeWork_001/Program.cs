// Задача №2:Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

/*
Console.Write("Введите первое число: ");
int addnumber_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int addnumber_2 = Convert.ToInt32(Console.ReadLine());
if (addnumber_1 < addnumber_2) 
{
    Console.WriteLine (" число " + addnumber_2 + " максимальное");
}
if (addnumber_1 > addnumber_2) 
{
    Console.WriteLine (" число " + addnumber_1 + " максимальное");
}
*/

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

/*
Console.Write("Введите первое число: ");
int addnumber_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int addnumber_2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int addnumber_3 = Convert.ToInt32(Console.ReadLine());

int max = addnumber_1;

if (addnumber_1 < addnumber_2)
{
    max = addnumber_2;
}
if (addnumber_2 < addnumber_3)
{
    max = addnumber_3;
}
Console.WriteLine (max + " максимальное число");
*/

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

/*
Console.Write("Введите число: ");
int addnumber = Convert.ToInt32(Console.ReadLine());

if (addnumber % 2 == 0)
{
    Console.WriteLine (addnumber + " - четное число");
}
else
{
    Console.WriteLine (addnumber + " - нечетное число");
}
*/

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

/*
Console.Write("Введите первое число: ");
int addnumber = Convert.ToInt32(Console.ReadLine());
int start = 1;
while (start <= addnumber)
{
    if (start % 2 == 0)
    {
    Console.Write (start + ",");
    }
    start = start + 1;
}
*/