/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

Console.WriteLine("Введите первое число");
string num1 = Console.ReadLine();

Console.WriteLine("Введите второе число");
string num2 = Console.ReadLine();

Console.WriteLine("Введите третье число");
string num3 = Console.ReadLine();

int a = int.Parse(num1);
int b = int.Parse(num2);
int c = int.Parse(num3);

if (a >= b)

   if (a >= c)
   Console.Write($"{a}, {b}, {c} -> {a}");

   else
   Console.Write($"{a}, {b}, {c} -> {c}");

else if (a <= b)

    if (b >= c)
     Console.Write($"{a}, {b}, {c} -> {b}");
    else
     Console.Write($"{a}, {b}, {c} -> {c}");


