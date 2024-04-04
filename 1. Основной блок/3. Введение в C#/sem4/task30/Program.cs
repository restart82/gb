// Задача 30:
// Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int N = 20; //Количество элементов в массиве

int[] FillArray(int N)
{
    int[] array = new int[N];
    for (int i = 0; i < N; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    return array;
}

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
    }
    Console.WriteLine("");
}

int[] ar = FillArray(N);
WriteArray(ar);


