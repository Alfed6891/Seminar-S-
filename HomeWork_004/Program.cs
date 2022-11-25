int Readint (string massage)
{
    Console.Write (massage);
    return Convert.ToInt32 (Console.ReadLine());
}



// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Без использования функции Math.Pow.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int number_A = Readint("Введите число A: ");
int number_B = Readint("Введите число B: ");
int result = 1;
for(int i = 0; i < number_B; i++)
{
    result = result * number_A;
}
Console.WriteLine($"Число A в натуральной степени B равно: {result}");



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int addnumber = Readint("Введите число: ");
int resultsum = 0;

while (addnumber > 0)
{
    resultsum = resultsum + (addnumber % 10);
    addnumber /= 10;
}
Console.WriteLine($"Сумма цифр этого числа равна: {resultsum}");



//Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран. Вывод сделать отдельным методом.
// 5 -> [1, 2, 5, 7, 19]
// 3 -> [6, 1, 33]


int sise = Readint("Введите длинну масива: ");
int[] numbers = new int [sise]; 
for (int i=0; i < numbers.Length; i++)
{
   numbers[i] = new Random().Next(0,100);
} 
PrintArray (numbers);


void PrintArray (int[] array)
{
    int i = 0;
    Console.Write ($"Масив длинной {array.Length} ячеек имеет следующие значения: [");
    for (i=0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[i]}]");
}
   