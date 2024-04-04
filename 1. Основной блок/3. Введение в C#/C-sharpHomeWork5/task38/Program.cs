// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

double[] GetDoubleArray(int size, int minVal, int maxVal)
{
    double[] arr = new double[size];
    for (int i = 0; i < size; i++) arr[i] = new Random().Next(minVal, maxVal) + Math.Round(new Random().NextDouble(), 1);
    return arr;
}

double[] array = GetDoubleArray(10, 0, 10);
double MaxValue = array.Max(), MinValue = array.Min();
double diff = MaxValue - MinValue;
Console.WriteLine($"Разница между максимальным значением (max = {MaxValue}) и минимальным значением (min = {MinValue}) массива:\n[{String.Join("; ", array)}]\n diff = {diff}");





