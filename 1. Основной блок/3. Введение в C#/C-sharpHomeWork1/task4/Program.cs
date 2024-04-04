// Задача 4:
// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int N = 3; // Количество чисел
int[] numbers = new int[N]; // Массив из N элементов

int i_max = 0;

for(int i = 0; i < N; i++)
{
    Console.Write("Введите " + (i + 1) + "-е число: ");
    numbers[i] = int.Parse(Console.ReadLine()!);
    if(numbers[i] > numbers[i_max])
        i_max = i;
}

Console.WriteLine("max = " + numbers[i_max]);

