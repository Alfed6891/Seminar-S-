void FillArrayRandomNumbers(int[] array)
{
for(int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(1, 10);
}
}

void WriteArray(int[] array)
{
for(int i = 0; i < array.Length; i++)
{
Console.Write(array[i] + " ");
}
Console.WriteLine();
}

int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}

int[] CopyArray(int[] array)
{
int[] copyArray = new int[array.Length];
for(int i = 0; i < array.Length; i++)
{
copyArray[i] = array[i];
}
return copyArray;
}

/*
int size = ReadInt("Введите размер массива: ");
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
WriteArray(numbers);

int[] revertNumbers = new int[size];
for(int i = 0; i < revertNumbers.Length; i++)
{
revertNumbers[i] = numbers[numbers.Length - 1 - i];
}
WriteArray(revertNumbers);
*/

/*
int size = ReadInt("Введите размер массива: ");
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
WriteArray(numbers);

for(int i = 0; i < numbers.Length / 2; i++)
{
int temp = numbers[numbers.Length - 1 - i];
numbers[numbers.Length - 1 - i] = numbers[i];
numbers[i] = temp;
}
WriteArray(numbers);
*/

// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

/*
int lineA = ReadInt("Введите сторону A: ");
int lineB = ReadInt("Введите сторону B: ");
int lineC = ReadInt("Введите сторону C: ");

if(CheckSide(lineA, lineB, lineC) && CheckSide(lineB, lineA, lineC) && CheckSide(lineC, lineB, lineA))
{
Console.WriteLine("Да");
}
else
{
Console.WriteLine("Нет");
}

bool CheckSide(int checkSide, int a , int b)
{
return checkSide < a + b;
}
*/



// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

/*
int number = ReadInt("Введите десятичное число: ");
string binaryNumber = "";
int baseNumber = 2;
while(number > 0)
{
int divider = number % baseNumber;
binaryNumber = divider + binaryNumber;
number /= baseNumber;
}
Console.WriteLine(binaryNumber);
*/

/*
int number = ReadInt("Введите десятичное число: ");
int baseNumber = 2;
int tempNumber = number;
int count = 0;
while(tempNumber > 0)
{
count++;
tempNumber /= baseNumber;
}
int[] binary = new int[count];

for(int i = binary.Length - 1; i >= 0; i--)
{
binary[i] = number % baseNumber;
number /= baseNumber;
}

WriteArray(binary);
*/

// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

/*
int count = ReadInt("Введите количество членов ряда Фибоначчи: ");
int firstNumber = 0;
int secondNumber = 1;

if(count > 0)
Console.Write(firstNumber + " ");
if(count > 1)
Console.Write(secondNumber + " ");

for (int i = 2; i < count; i++)
{
int nextNumber = firstNumber + secondNumber;
firstNumber = secondNumber;
secondNumber = nextNumber;
Console.Write(nextNumber + " ");
}
*/

/*
int count = ReadInt("Введите количество членов ряда Фибоначчи: ");
int[] fibonacci = new int[count];

if(count > 0)
fibonacci[0] = 0;
if(count > 1)
fibonacci[1] = 1;

for (int i = 2; i < count; i++)
{
fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
}
WriteArray(fibonacci);
*/



// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

/*
int size = ReadInt("Введите размер: ");
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);

int[] copyNumbers = CopyArray(numbers);
WriteArray(numbers);
WriteArray(copyNumbers);
*/

Console.Write("Введите числа через запятую: ");
string? inputNumbers = Console.ReadLine();
char splitSymbol = ',';

WriteArray(ParseArray(inputNumbers, splitSymbol));





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
