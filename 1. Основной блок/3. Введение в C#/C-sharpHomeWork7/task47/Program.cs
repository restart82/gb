// Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

double[,] GetDouble2DArray(int m, int n, int minValue, int maxValue)
{
    double[,] array = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue) + Math.Round(new Random().NextDouble(), 2);
        }
    }
    return array;
}

void ShowArray(double[,] array)
{
    Console.WriteLine($"\nСгенерированная матрица [{array.GetLength(0)}x{array.GetLength(1)}]:\n");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine("\n");
    }
}

int InputData(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

Console.Clear();
int m = InputData("Введите количество строк >");
int n = InputData("Введите количество столбцов >");
int min = 0, max = 10;
double[,] arr = GetDouble2DArray(m, n, min, max);
ShowArray(arr);