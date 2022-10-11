/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет */

Console.WriteLine("Введите число");
string num = Console.ReadLine();

int a = int.Parse(num);
int ostatok = a%2;

if (ostatok == 0)
Console.Write($"{a} - чётное");

else
Console.Write($"{a} - нечётное");