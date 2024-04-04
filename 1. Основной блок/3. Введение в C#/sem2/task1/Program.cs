// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

void Max(int num)
{
    int a = num % 10;
    int b = num / 10;
    if(a > b)
        Console.WriteLine("Это его максимальная цифра: " + a);
    else
        Console.WriteLine("Это его максимальная цифра: " + b);
}

int number = new Random().Next(10, 100); // это вот такой диапазон: [10, 100)
Console.WriteLine("Вот двухзначное число: " + number);
Max(number);
