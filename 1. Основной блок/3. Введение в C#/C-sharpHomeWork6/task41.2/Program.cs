
int[] NewArray()
{
    Console.Write("Введите числа через пробел: ");
    int[] arr = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
    return arr;
}

int HowMuchGreaterZero(int[] arr)
{
    int k = 0;
    foreach (int al in arr) if (al > 0) k++;
    return k;
}

int[] array = NewArray();
int n = HowMuchGreaterZero(array);
Console.WriteLine($"Вы ввели {n} числа > 0");