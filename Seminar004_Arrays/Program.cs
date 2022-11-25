/*
int Readint (string massage)
{
    Console.Write (massage);
    return Convert.ToInt32 (Console.ReadLine());
}
*/

/*
int addnumber = Readint ("Введите число по поторое будет считаться сумма: ");
int sum = 0;
int i = 1;
while(i <= addnumber)
{
    sum += i;
    i++;
}
Console.WriteLine ("Сумма равна " + sum);
*/

/*
int addnumber = Readint ("Введите число по поторое будет считаться сумма: ");
int sum = 0;
for(int i = 1; i <= addnumber; i++)
{
    sum += i;
}
Console.WriteLine ($"Сумма равна: {sum}");
*/

// Задача 26. Напишите программу, которая принимает на вход число
// и выдает количество цифр в числе.
// 456 -> 3 
// 78 -> 2
// 89126 -> 5

/*
int addnumber = Readint ("Введите число: ");
int totalnumbers = 0;
while (Math.Abs(addnumber)>0)
{
    //addnumber = addnumber/10;
    addnumber /= 10;
    totalnumbers++;
}

if (totalnumbers == 0)
{
    totalnumbers = 1;
}
Console.WriteLine ($"Всего цифр в этом числе: {totalnumbers}");
*/

// Задача 28. Напишите программу, которая принимает на вход число N,
// и выдает произведение чисел от 1 до N
// 4 -> 24
// 5 -> 120

/*
int number_N = Readint ("Введите число: ");
int composition = 1;
for (int i = 1; i <= number_N; i++)
{
    //composition = composition * i;
    composition *= i;
}
Console.WriteLine(composition);
*/

// int[] numbers = new int [5] {3,5,4,5,8};
// тип данных в масиве[] название = инициализация-(new) тип [количество ячеек] {значения через запятую, в соответствии с количеством ячеек};

// int[] numbers = {3,5,4,5,8};

// int[] numbers;
// numbers = new int[] {3,5,4,5,8};

// numbers [0] = 90; присваивание значения 90 в ячейку [0]

/*
for(int i = 0; i < numbers.Length; i++)
{
    Console.Write (numbers[i] + " ");
}
*/

// int [] temp = new int [numbers.Length + 1];  - Увеличение длинны масива через копирование его в более длинный масив

/*
string name = "Alfed";
char simbol = '!';
Console.WriteLine(name.Length);
*/

// Задача 30. Напишите программу, которая выводит масив из 8 элементов,
// заполненый нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

/*
int sise = 8;
int[] numbers = new int [sise]; 
for (int i=0; i < numbers.Length; i++)
{
   numbers[i] = new Random().Next(0,2);
   Console.Write (numbers [i] + " ");
} 
*/
