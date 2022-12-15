
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

int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}

/*
int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] numbers = new int[rows, columns];
FillMatrixRandomNumbers(numbers);
WriteMatrix(numbers);
*/

// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

/*
int rows_m = ReadInt("Введите количество строк: ");
int columns_n = ReadInt("Введите количество столбцов: ");

int [,] matrix = new int [rows_m,columns_n];

for(int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(1); j++)
        {
        matrix[i, j] = i+j;
        }
}
WriteMatrix(matrix);
*/
/*
int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] numbers = new int[rows, columns];
FillMatrixRandomNumbers(numbers);
WriteMatrix(numbers);

for(int i = 1; i < numbers.GetLength(0); i+=2)
{
    for(int j = 1; j < numbers.GetLength(1); j+=2)
        {
        numbers[i, j] *= numbers[i, j];
        }
}

WriteMatrix(numbers);
*/

// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] numbers = new int[rows, columns];
int sum = 0;
FillMatrixRandomNumbers(numbers);

int minLength = numbers.GetLength(0);
if(numbers.GetLength(1) < minLength)
{
    minLength = numbers.GetLength(1);
}

for(int i = 0; i < minLength; i++)
{
sum += numbers[i, i];
}

WriteMatrix(numbers);
Console.WriteLine(sum);
