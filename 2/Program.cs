/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

Console.WriteLine("Введите первое число");
string num1 = Console.ReadLine();

Console.WriteLine("Введите второе число");
string num2 = Console.ReadLine();

int a = int.Parse(num1);
int b = int.Parse(num2);

if (a > b)
Console.Write($"a = {a}; b = {b} -> max = {a}");

else
Console.Write($"a = {a}; b= {b} -> max = {b}");