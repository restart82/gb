// *** Напишите программу, которая заполнит спирально массив 4 на 4.

// Как будет заполнятся массив *(n = n - 1):
// 1.(0,0)(0,1)...(0,n)
// 2.(1,n)(2,n)...(n,n)
// 3.(n,n-1)(n,n-2)...(n,0)
// 4.(n-1,0)(n-2,0)...(1,0)

void ShowArray(int[,] array, string message)
{
    Console.WriteLine($"\n{message} [{array.GetLength(0)}x{array.GetLength(1)}]:\n");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine("\n");
    }
}

int n = 4;
int[,] matrix = new int[n, n];
int number = 1;
int loop = 0;

while(number <= n * n)
{
    for (int j = loop; j < n - loop; j++)
    {
        matrix[loop, j] = number;
        number++;
    }
    for (int i = loop + 1; i < n - loop; i++)
    {
        matrix[i, n - loop -1] = number;
        number++; 
    }
    for (int j = n - loop - 2; j >= loop; j--)
    {
        matrix[n - loop - 1, j] = number;
        number++;
    }
    for (int i = n - loop - 2; i >= loop + 1; i--)
    {
        matrix[i, loop] = number;
        number++; 
    }
    loop++;
}

ShowArray(matrix, "Спиральный массив");