// Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

void Multiple(int num1, int num2)
{
    if(num1 % num2 == 0)
        Console.WriteLine("Кратно");
    else
        Console.WriteLine(num1 % num2);
}

Console.Write("Введите первое число: ");
int Number1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int Number2 = int.Parse(Console.ReadLine()!);

Multiple(Number1, Number2);