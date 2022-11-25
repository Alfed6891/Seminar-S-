// Задача 17 Напишите программу, которая принимает на вход координаты точки (X,Y)
// Причем X != 0, Y != 0 и  выдает номер четверти плоскости, в которой находится эта точка.
/*
int Readint (string massage)
{
    Console.Write (massage);
    return Convert.ToInt32 (Console.ReadLine());
}

int x = Readint ("Введите точку x: ");
int y = Readint ("Введите точку У: ");

if (x == 0 || y == 0)
{
    Console.WriteLine ("x и y не могут быть равны 0");
    return;
}

if (x > 0 && y > 0)
{
Console.WriteLine("Число находится в 1 четверти");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("Число находится в 2 четверти");
}
else if (x < 0 && y < 0)
{
Console.WriteLine("Число находится в 3 четверти");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("Число находится в 4 четверти");
}
*/

// Задача 18 Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x,y)


int Readint (string massage)
{
    Console.Write (massage);
    return Convert.ToInt32 (Console.ReadLine());
}
/*
int quarter = Readint("введите номер четверти: ");

/*
if (quarter == 0 || quarter > 4)
{
    Console.WriteLine (" Введите номер четверти от 1 до 4: ");
}
if (quarter == 1)
{
    Console.WriteLine ("Диапазон значений x от - 1 до -бесконечности, диапазон y от 1 до бесконечности");
}
if (quarter == 2)
{
    Console.WriteLine ("Диапазон значений x от -1 до -бесконечности, диапазон y от -1 до -бесконечности");
}
if (quarter == 3)
{
    Console.WriteLine ("Диапазон значений x от 1 до бесконечности, диапазон y от -1 до -бесконечности");
}
if (quarter == 4)
{
    Console.WriteLine ("Диапазон значений x от 1 до бесконечности, иапазон y от 1 до бесконечности");
}
*/
/*
// switch - Метод позволябщий перебрать все варианты (case) для переменной
// default - при отсутствии искомого аргумента позволяет вывести соответствующий результат
switch(quarter)
{
    case 1:
        Console.WriteLine ("x > 0, y > 0");
        break;
    case 2:
        Console.WriteLine ("x < 0, y > 0");
        break;
    case 3:
        Console.WriteLine ("x < 0, y < 0");
        break;
    case 4:
        Console.WriteLine ("x > 0, y < 0");
        break;
    default:
        Console.WriteLine ("Нет такой четверти");
        break;
}
*/

// Задача 21. Напишите программу, которая принимает на вход координаты 2 точек
// и находит расстояние между ними в 2D пространстве
// A (3,6); B(2,1) -> 5,09
// A (7,-5); B(1, -1) -> 7,21

/*
int xA = Readint ("Введите координаты первой точки по оси x: ");
int yA = Readint ("Введите координаты первой точки по оси y: ");
int xB = Readint ("Введите координаты второй точки по оси x: ");
int yB = Readint ("Введите координаты второй точки по оси y: ");
int sqrline_1 = (xA - xB)*(xA-xB);
int sqrline_2 = (yA - yB)*(yA - yB);
double distans = Math.Sqrt (sqrline_1)+(sqrline_2);
Console.WriteLine(distans);
*/

// Напишите программу, которая принимает на вход число (N)
// и выдает таблицу квадратов чисел от 1 до N

/*
int number = Readint ("Введите число: ");
int i = 1;

while (i < number)
{
    Console.Write (i*i + " ");
    i++;
}
*/