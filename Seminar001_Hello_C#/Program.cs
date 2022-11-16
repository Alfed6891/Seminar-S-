// Тип и название;
// int - целые числа;
// double - дробные числа;
// string - строка;
// boot - true/false (истина/ложь);

// int a = 5;
// double b = 10.5;
// string name = "Alex";
// bool isTrue = true;

// Математические операторы:
// (+) (-) (*) (/) - сложение, вычитание, умножение, деление;
// (%) - вычисление остатка деления;

// string name = "Moscow";
// string department = "home";
// string result = name + department

// if(a>b);                             - true/false
//  {
//   Console.Write("да");               - если условие выполняется, выполняется инструкция,
//  }                                   если нет, то код выполняется далее.

// else (a+1>b);
// {
// Console.Write("больше чем да");      - дополнительное условие
// }                   
//

// int a = 5;
// int b = 10;

// while (a < b);                           - true/false
// {
//   Console.Write (a " меньше" b);         - выполняемое действие
//                                            действие вполняется до тех пор пока выполняется условие, до бесконечности
//  a = a + 1; (a ++;) (a += 1;)            - Изменение условия для цикла + 1
//  a = a - 1; (a --;) (a -= 1;)            - Изменение условия для цикла - 1
// }

//int namber = 4;
//int sqr = namber * namber;
//Console.WriteLine(sqr);

// int number = new Random().Next(10,20);   - Команда позволяет найти случайное число в диалпазоне от n до n-1
// Console.WriteLine(namber);
// int sqr = number * number;
// Console.WriteLine(sqr);

// Console.Write("Введите число: ");
// int addnumber = Convert.ToInt32(Console.ReadLine());  - команда позволяет перевести значение строки в число
// int sqr = addnumber * addnumber;
// Console.WriteLine(sqr);

// Задача № 1
// Console.Write("Введите первое число ");
// int addnumber_1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число ");
// int addnumber_2 = Convert.ToInt32(Console.ReadLine());
// if (addnumber_1 == addnumber_2*addnumber_2) 
// {
//     Console.WriteLine("Число " + addnumber_1 + " является квадратом числа " + addnumber_2);
// }
// else
// {
//     Console.WriteLine("Число " + addnumber_1 + " не является квадратом числа " + addnumber_2);
// }

// Задача № 3
// Console.Write("Какой по счету день недели: ");
// int day_namber = Convert.ToInt32(Console.ReadLine());
// if (day_namber == 1) 
// {
//     Console.WriteLine("Это понеделник");
// }
// else if(day_namber == 2) 
// {
//     Console.WriteLine("Это вторник");
// }
// else if(day_namber == 3) 
// {
//     Console.WriteLine("Это среда");
// }
// else if(day_namber == 4) 
// {
//     Console.WriteLine("Это четверг");
// }
// else if(day_namber == 5) 
// {
//     Console.WriteLine("Это пятница");
// }
// else if(day_namber == 6) 
// {
//     Console.WriteLine("Это суббота");
// }
// else if(day_namber == 7) 
// {
//     Console.WriteLine("Это воскресенье");
// }
// else
// {
//     Console.WriteLine ("А такого я не знаю...");
// }

/* Задача № 5
 Console.Write("Введите число: ");
int namber = Convert.ToInt32(Console.ReadLine());
int negnamber = -namber;
while (negnamber <= namber)
    {
        Console.Write (negnamber);
        negnamber = negnamber + 1;
    }
*/

/* Задача № 7
Console.Write("Введите число: ");
int namber = Convert.ToInt32(Console.ReadLine());
int lastnamber = namber % 10;
Console.Write(lastnamber);
*/
