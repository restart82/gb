// ***...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] Get3DArray(int m, int n, int p, int minValue, int maxValue)
{
    int[,,] array = new int[m, n, p];
    int[] numbers = new int[m * n * p];
    int q = 0;
    for (int i = 0; i < m; i++) //Заполняем i
    {
        for (int j = 0; j < n; j++) //Заполняем j
        {
            for (int k = 0; k < p; k++) //Заполняем k
            {
                bool flag = false;
                while (flag == false)   //Проверка на уникальность. Будем сравнивать новый элемент с каждым предыдущим.
                {                       //Каждый элемент сохраним в одномерный массив для удобства сравнения новых элементов.
                    array[i, j, k] = new Random().Next(minValue, maxValue + 1);
                    for (int w = 0; w <= q; w++)
                    {
                        if (array[i, j, k] == numbers[w])
                        {
                            flag = false;
                            break;
                        }
                        else
                        {
                            flag = true;
                        }
                    }
                }
                numbers[q] = array[i, j, k];
                q++;
            }
        }
    }
    // Array.Sort(numbers);
    // Console.WriteLine(String.Join(" ", numbers));
    return array;
}

void Show3DArray(int[,,] array, string message)
{
    Console.WriteLine($"\n{message} [{array.GetLength(0)}x{array.GetLength(1)}x{array.GetLength(2)}]:\n");
    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j, k]} ({i},{j},{k})\t");
            }
            Console.WriteLine("\n");
        }
        Console.WriteLine();
    }
}

Console.Clear();
int[,,] matrix = Get3DArray(2, 2, 4, 10, 99);
Show3DArray(matrix, "3D массив из неповторяющихся двузначных чисел");

