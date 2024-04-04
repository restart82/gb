// Задача 8:
// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число N: ");
int number = int.Parse(Console.ReadLine()!);

if(number > 1)
{
    int start = 2;
    while(start <= number)
    {
        Console.Write(start + " ");
        start = start + 2;
    }
}
else
    Console.Write("N должно быть > 1");