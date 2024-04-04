// Задача: Написать программу, которая из имеющегося массива строк формирует
// новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

Console.Clear();
int arrayLenhth = InputNumber("Введите длину масива >");
if (ChechNumber(arrayLenhth))
{
    Console.WriteLine();
    string[] firstArray = InputData(arrayLenhth);
    string[] secondArray = GetNewArray(firstArray);
    Console.WriteLine();
    Console.WriteLine("Результат работы программы: ");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write($"[{String.Join(", ", firstArray)}] --> ");
    Console.Write($"[{String.Join(", ", secondArray)}]");
    Console.ResetColor();
}

string[] GetNewArray(string[] oldArray) //метод возвращает массив соглано уловиям задачи
{
    string[] newArray = new string[oldArray.Length];
    int k = 0;
    for (int i = 0; i < oldArray.Length; i++)
    {
        if (oldArray[i].Length <= 3)
        {
            newArray[k] = oldArray[i];
            k++;
        }
    }
    Array.Resize(ref newArray, k);
    return newArray;
}

string[] InputData(int n) //метод возвращает строковый массив, введеный с клавиатуры
{
    string[] array = new string[n];
    Console.WriteLine($"Введите массив:");
    for (int i = 0; i < n; i++)
    {
        Console.Write(i + 1 + ". >");
        array[i] = Console.ReadLine()!;
    }
    return array;
}

int InputNumber(string message) //метод возвращает число, введеное с клавиатуры
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

bool ChechNumber(int number) //метод возвращает истину, если чило положительное
{
    if (number > 0) return true;
    else
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("!!! Число должно быть > 0 !!!");
        Console.ResetColor();
        return false;
    }
}