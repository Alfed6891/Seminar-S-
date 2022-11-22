// Напишите программу, которая будет выбирать случайно число в диапазоне от 10 до 99 и будет показвать наибольшую цифру этого числа
// 78 -> 8
// 16 -> 6

/*
int randomnumber = new Random().Next(10,100);
int lastDidgit = randomnumber % 10;
int firstdigit = randomnumber / 10;

Console.WriteLine ("Я задумал число:" + randomnumber);

if (lastDidgit > firstdigit)
{
    Console.WriteLine ("цифра " + lastDidgit + " наибольшая");
}
else
{
    Console.WriteLine ("цифра " + firstdigit + " наибольшая");
}
*/

// Напишите программу, которая будет выбирать случайно число в диапазоне от 100 до 999 и будет удалять 2 цифру этого числа
// 786 -> 76
// 161 -> 11

/*
int randomnumber = new Random().Next(100,1000);
int lastDigit = randomnumber % 10;
int firstDigit = randomnumber / 100;
Console.WriteLine ("Я задумал число:" + randomnumber);
// Console.Write (firstDigit);
// Console.WriteLine (lastDidgit);
Console.WriteLine ($"{firstDigit}{lastDigit}");
*/

// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

/*
Console.Write("Введите первое число: ");
int addnumber_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int addnumber_2 = Convert.ToInt32(Console.ReadLine());
int remains = addnumber_1 % addnumber_2;

if (remains == 0)
{
    Console.WriteLine ("Число 1 кратно числу 2");
}
if (addnumber_1 % addnumber_2 !>0)
{
    Console.WriteLine ($"не кратно, остаток: {remains}");
    // выражение ($ "Текст {ПЕРЕМЕННАЯ}{ПЕРЕМЕННАЯ}) - интерпроляция, способ перечисления множества переменных без применения + и ""
}
*/

/*
void firstMethod ()
// void - ничего не возвращать
// int - вернуть число
// string - вернуть строку
{
    Console.WriteLine ("Hello");
}

firstMethod();
firstMethod();
firstMethod();
*/

/*
string firstMethod () 
{
    return "Hello";
}
// возврвщает строку в функию, для далнейших действий требуется добавления новых инструкций
Console.WriteLine (firstMethod());
*/

/*
int Sum (int first, int second)
{
    int sum = first + second;
    return sum;
}
Console.WriteLine (Sum(2 , 5));
*/

// процедура (функция которая ничего не возвращает)
// функция (самостоятельный элемент кода спосоный возвращать значение)
// метод (любая функция или процедура существует в контексте обьектоориентированного програмирования)

/*
int Readint (string massage)
{
    Console.Write (massage);
    return Convert.ToInt32(Console.ReadLine());
}

int addnumber_1 = Readint ("Введите первое число: ");
int addnumber_2 = Readint ("Введите второе число: ");
int remains = addnumber_1 % addnumber_2;

if (remains == 0)
{
    Console.WriteLine ("Число 1 кратно числу 2");
}
if (addnumber_1 % addnumber_2 !>0)
{
    Console.WriteLine ($"не кратно, остаток: {remains}");
}
*/
/*
int a = 10;
int b = 5;
int c = 10;
int d = 5;

if (a>b && a>c)
// && - значение "и" (при использовании одинарной & происходит проверка всехлогических выражений и склеивание в одно значение истина или ложь)
// != - начение "не равно" (! - "не")
// || - значение "или"
{
    Console.Write("а - больше всех");
}
*/

// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно
//             7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

/*
int Readint (string massage)
{
    Console.Write (massage);
    return Convert.ToInt32(Console.ReadLine());
}

bool IsMultiple (int first, int second)
{
    return first % second == 0;
}

int addnumber = Readint ("Введите число: ");
int a = 7;
int b = 23;

if (IsMultiple(addnumber, a) && IsMultiple(addnumber, b))
{
    Console.WriteLine ("Yes");
}
else
{
    Console.WriteLine ("No");
}
*/

// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8, 9 -> нет


int Readint (string massage)
{
    Console.Write (massage);
    return Convert.ToInt32(Console.ReadLine());
}

int Sqr (int number)
{
    return number * number;
}

int addnumber_1 = Readint ("Введите первое число: ");
int addnumber_2 = Readint ("Введите второе число: ");
if (addnumber_1 == Sqr(addnumber_2) || addnumber_2 == Sqr (addnumber_1))
{
    Console.WriteLine ("Yes");
}
else
{
    Console.WriteLine ("No");
}


