// Задача №1.
// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет//

Console.Write("Введите число A: ");
int number_a = int.Parse(Console.ReadLine()!);
Console.Write("Введите число B: ");
int number_b = int.Parse(Console.ReadLine()!);

if(number_a == (number_b * number_b))
    Console.WriteLine("yes");
else
    Console.WriteLine("no");