
int Readint (string massage)
{
    Console.Write (massage);
    return Convert.ToInt32 (Console.ReadLine());
}

void FillArrayRandomNumbers (int[] array, int min, int max)
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

void ConvertDoubleRandom (double[] array, int min, int max)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToDouble (new Random().Next(min, max)/10.0);
    }
}



// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int sise_1 = Readint("Введите длинну массива: ");
int [] array_1 = new int [sise_1];
int count = 0;
FillArrayRandomNumbers (array_1, 100, 999);
WriteArray(array_1);

for (int i =  0; i < array_1.Length; i++)
{
    if (array_1[i] % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine ($"Количество четных элементов массива: {count}");



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int sise_2 = Readint("Введите длинну массива: ");
int [] array_2 = new int [sise_2];
int sum = 0;
FillArrayRandomNumbers (array_2, -10, 10);
WriteArray(array_2);

for (int i = 0; i < array_2.Length ; i++)
{
    if (i % 2 != 0)
    {
        sum += array_2[i];
    }
    
}
Console.WriteLine ($"Сумма элементов массива стоящих в нечетных позициях: {sum}");



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
// [3 7 22 2 78] -> 76

int sise_3 = Readint("Введите длинну массива: ");
double [] array_3 = new double [sise_3];
double max = 0;
double min = 100;
double result = 0.0;
ConvertDoubleRandom (array_3, 99, 999);
for(int i = 0; i < array_3.Length; i++)
    if(array_3[i] > max)
    {
        max = array_3 [i];
    }
    else if (array_3[i] < min)
    {
        min = array_3[i];
    }

result = max - min;

Console.WriteLine ("В массиве [" + string.Join(", ", array_3) + "] разница между максимальным и минимальным элементом = " + result);
Console.WriteLine ("максимальное значение " + max);
Console.WriteLine ("Минимальное значение " + min);