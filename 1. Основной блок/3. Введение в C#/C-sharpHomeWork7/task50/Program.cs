// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] Get2DArray(int m, int n, int minValue, int maxValue)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void ShowArray(int[,] array)
{
    Console.WriteLine($"\nИмеется матрица [{array.GetLength(0)}x{array.GetLength(1)}]:\n");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine("\n");
    }
}

int[] InputData()
{
    Console.WriteLine("Какой элемент вам нужен?");
    Console.Write("Введите позицию элемента через пробел: ");
    int[] result = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
    return result;
}

bool ChekPosition(int[,] array, int[] position)
{
    if (position[0] - 1 > array.GetLength(0) | position[1] - 1 > array.GetLength(1)) return false;
    else return true;
}

Console.Clear();
int row = new Random().Next(2, 7);
int col = new Random().Next(2, 7);
int min = 0, max = 10;
int[,] arr = Get2DArray(row, col, min, max);
ShowArray(arr);
int[] position = InputData();
if (ChekPosition(arr, position))
{
    Console.WriteLine("Вот искомый элемент: " + arr[position[0] - 1, position[1] - 1]);
}
else
{
    Console.WriteLine("Такого элемента нет :(");
}




