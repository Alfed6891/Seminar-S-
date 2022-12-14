double ReadConvertDouble (String massage)
{
    Console.Write(massage);
    return Convert.ToDouble(Console.ReadLine());
}

int[] ParseArray(string inputNumbers, char split)
{
int numbersCount = 1;
for(int i = 0; i < inputNumbers.Length; i++)
{
    if(inputNumbers[i] == split)
    {
        numbersCount++;
    }
}
int[] numbers = new int[numbersCount];
int numberIndex = 0;
string subString = "";
for(int i = 0; i < inputNumbers.Length; i++)
{
if(inputNumbers[i] == split)
    {
    numbers[numberIndex++] = Convert.ToInt32(subString);
    subString = "";
    }
else
    {
    subString += inputNumbers[i];
    }
}
numbers[numberIndex] = Convert.ToInt32(subString);
return numbers;

}



// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4


Console.Write("Введите числа через запятую: ");
string? inputNumbers = Console.ReadLine();
char splitSymbol = ',';

int [] array = (ParseArray(inputNumbers, splitSymbol));
int countpositiv = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        countpositiv++;
    }
}
Console.WriteLine ($"Количество введенных подожительных чисел равно: {countpositiv}");



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double b1 = ReadConvertDouble ("Введите Значение b1: ");
double k1 = ReadConvertDouble ("Введите значение К1: ");
double b2 = ReadConvertDouble ("Введите Значение b2: ");
double k2 = ReadConvertDouble ("Введите значение К2: ");
double x = 0;
double y = 0;

if (k1 == k2)
{
    Console.WriteLine ("Найти точку прересечеия невозможно!");
}
else if (k1 != k2)
{
    x = -(b1 - b2)/(k1 - k2);
    y = k1 * x + b1;
}
Console.WriteLine ($"Точка пересечения прямых: ({x}; {y})");
