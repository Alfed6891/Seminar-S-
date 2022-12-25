
void FillMatrixRandomDouble(double[,] array)
{

    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = Convert.ToDouble (new Random().Next(99, 999)/10.0);
            }
    }
}

void WriteMatrixDouble(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void WriteMatrix(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FillMatrixRandomNumbers(int[,] array)
{
for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = new Random().Next(1, 10);
            }
    }
}


// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
//1 -3,3 8 -9,9
// 8 7,8 -7,1 9


int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
double[,] numbers = new double[rows, columns];
FillMatrixRandomDouble (numbers);
WriteMatrixDouble(numbers);


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


int n = 10;
int m = 10;
double[,] numbers_2 = new double[n,m];
FillMatrixRandomDouble (numbers_2);
WriteMatrixDouble(numbers_2);

int line = ReadInt("Введите номер строки: ");
int column = ReadInt("Введите номер столбца: ");

if (line > n || column > m)
{
    Console.WriteLine("Такого элемента нет");
}
else
{
    Console.WriteLine($"В ячейке сохранено значение {numbers_2[line-1,column-1]}");
}



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int rows_3 = ReadInt("Введите количество строк: ");
int columns_3 = ReadInt("Введите количество столбцов: ");

int[,] numbers_3 = new int[rows_3, columns_3];
FillMatrixRandomNumbers (numbers_3);
WriteMatrix (numbers_3);

for (int j = 0; j < numbers_3.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < numbers_3.GetLength(0); i++)
    {
        avarage = (avarage + numbers_3[i, j]);
    }
    avarage = avarage / numbers_3.GetLength(1);
    Console.Write(avarage + "; ");
}
Console.WriteLine();
