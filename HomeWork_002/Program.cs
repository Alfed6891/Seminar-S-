// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

/*
int Readint (string massage)
{
    Console.Write (massage);
    return Convert.ToInt32(Console.ReadLine());
}

int addnumber = Readint("Введите трехзначное число: ");
int tempnumber = addnumber / 10;
int twonumber = tempnumber % 10;
Console.WriteLine ($"Вторая цифра этого числа: {twonumber}");
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

/*
int Readint (string massage)
{
    Console.Write (massage);
    return Convert.ToInt32(Console.ReadLine());
}

int addnumber = Readint("Введите число: ");
int multiplier = 1;
int tempnumber = addnumber;

if (addnumber < 99)
{
    Console.WriteLine ("Третьей цифры у числа нет");
}
else
{
    while (addnumber / 10 != 0)
    {
    int addnumber = addnumber / 10;
    int multiplier = multiplier * 10;
    }
    int multiplier = multiplier / 100;
    int threenumber = (tempnumber/multiplier) % 10;
    Console.WriteLine ($"Третья цифра этого числа: {threenumber}");
}
*/

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

/*
int Readint (string massage)
{
    Console.Write (massage);
    return Convert.ToInt32(Console.ReadLine());
}

int weeknumber = Readint("Какой по счету день недели: ");
if (weeknumber == 6 || weeknumber == 7)
{
    Console.Write ("Да, выходной!");
}
else if (weeknumber > 7)
{
    Console.Write ("Я не знаю такого!");
}
else
{
    Console.Write ("Нет, это рабочий день!");
}
*/