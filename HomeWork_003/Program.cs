int Readint (string massage)
{
    Console.Write (massage);
    return Convert.ToInt32 (Console.ReadLine());
}



// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


int number = Readint ("Введите число из 5 цифр: ");

if (number/10000 == number % 10 && (number/1000) % 10 == (number % 100) / 10)
{
    Console.WriteLine ("Число палиндром");
}
else
{
    Console.WriteLine("Число не палиндром");
}



// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


int xA = Readint ("Введите координаты первой точки A по оси x: ");
int yA = Readint ("Введите координаты первой точки A по оси y: ");
int zA = Readint ("Введите координаты первой точки A по оси z: ");
int xB = Readint ("Введите координаты второй точки B по оси x: ");
int yB = Readint ("Введите координаты второй точки B по оси y: ");
int zB = Readint ("Введите координаты первой точки B по оси z: ");
int sqrline_1 = (xA - xB)*(xA - xB);
int sqrline_2 = (yA - yB)*(yA - yB);
int sqrline_3 = (zA - zB)*(zA - zB);
double distans = Math.Sqrt ((sqrline_1)+(sqrline_2)+(sqrline_3));
Console.WriteLine ($"Дистанция между точками: {distans}");



// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


int addnumber = Readint ("По какую цифру вычислить кубы: ");
int i = 1;

while (i <= addnumber)
{
    Console.Write (i*i*i + " ");
    i++;
}
