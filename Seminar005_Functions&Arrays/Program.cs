// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.

/*
int sise = 12;
int[] numbers = new int [sise];
int sumPositive = 0;
int sumNegative = 0;

FillrrayRandomNumbrs(numbers, -9, 9);
WriteArray(numbers);


for (int i=0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        //sumPositive = sumPositive + numbers [i];
        sumPositive += numbers[i];
    }
    if (numbers[i] < 0)
    {
        //sumNegative = sumNegative + numbers[i];
        sumNegative += numbers[i];
    }    
}
Console.WriteLine ("Сумма положительных чисел: " + sumPositive);
Console.WriteLine ("Сумма отрицательных чисел: " + sumNegative);
*/



void FillrrayRandomNumbrs (int[] array, int min, int max)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1); 
    }
}

void WriteArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write (array[i] + " ");
    }

    Console.WriteLine();
}



// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

/*
int sise = 5;
int [] array_1 = new int [sise];
FillrrayRandomNumbrs (array_1, -9, 9);
int [] newArray = new int [array_1.Length];

for (int i = 0; i < array_1.Length; i++)
{
    newArray[i] = -array_1 [i];
}
WriteArray(array_1);
WriteArray(newArray);
*/

//Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

int Readint (string massage)
{
    Console.Write (massage);
    return Convert.ToInt32 (Console.ReadLine());
}

/*
int sise_2 = Readint("Введите длинну массива: ");
int [] array_2 = new int [sise_2];
FillrrayRandomNumbrs (array_2, -9, 9);
WriteArray(array_2);

int searchnumber = Readint("Введите искомое число: ");

for(int i = 0; i < array_2.Length; i++)
{
    if (array_2[i] == searchnumber)
    {
        Console.WriteLine ($"Да, число {searchnumber} есть");
        break;
    }
    else if (i == array_2.Length - 1)
    {
        Console.WriteLine ("Нет такого числа");
    }
}
*/

/*
int sise_2 = Readint("Введите длинну массива: ");
int [] array_2 = new int [sise_2];
FillrrayRandomNumbrs (array_2, -9, 9);
WriteArray(array_2);

int searchnumber = Readint("Введите искомое число: ");
bool exist = false;

for(int i = 0; i < array_2.Length; i++)
{
    if (array_2[i] == searchnumber)
    {
        exist = true;
        break;
    }
}
if (exist)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
*/
// При исползовани переменной bool изначально выставляется значение ошибка, а после заменяется на истина при выполнении условия.
// if воспринимает аргумент напрямую и не требует дополнительных условий.



// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

/*
int sise_3 = 123;
int [] array_3 = new int [sise_3];
FillrrayRandomNumbrs (array_3, 1, 999);
WriteArray(array_3);

int quantitynumbers = 0;
for (int i = 0; i < array_3.Length; i++)
{
    if (array_3[i] > 9 && array_3[i] < 100)
    {
        quantitynumbers += 1;
    }
}
Console.WriteLine ($"Количество элементов массива в диапазоне от 10 до 99: {quantitynumbers}");
*/
/*
int size = ReadInt("Введите размер массива: ");
int[] numbers = new int[size];
int minSegment = 10;
int maxSegment = 99;
int count = 0;

FillArrayRandomNumbers(numbers, 1, 120);
WriteArray(numbers);

for(int i = 0; i < numbers.Length; i++)
{
if (numbers[i] < minSegment || numbers[i] > maxSegment)
continue;

count++;
}
Console.WriteLine(count);
*/



// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

/*
int size = ReadInt("Введите размер массива: ");
int[] numbers = new int[size];
int[] pairs;

FillArrayRandomNumbers(numbers, 1, 9);
WriteArray(numbers);

if (numbers.Length % 2 == 0)
{
pairs = new int[numbers.Length/2];
}
else
{
pairs = new int[numbers.Length/2 + 1];
pairs[pairs.Length - 1] = numbers[numbers.Length / 2];
}

for(int i = 0; i < numbers.Length / 2; i++)
{
pairs[i] = numbers[i] * numbers[numbers.Length - 1 - i];
}
WriteArray(pairs);
*/