#include <stdio.h>

// Ввести с клавиатуры массив из 5 элементов, найти среднее арифметическое
// всех элементов массива.

#define ARRAY_SIZE 5

void scanArrray(int arr[], int size)
{
    for (size_t i = 0; i < size; i++)
    {
        scanf("%d", arr + i);
    }
}

void printArray(int arr[], int size)
{
    for (size_t i = 0; i < size; i++)
    {
        printf("%d ", arr[i]);
    }
    printf("\n");
}

float getMean(int arr[], int size)
{
    float result = 0;
    for (size_t i = 0; i < size; i++)
    {
        result += arr[i];
    }
    return result / size;
}

int main(int argc, char const *argv[])
{
    int array[ARRAY_SIZE];
    scanArrray(array, ARRAY_SIZE);
    printf("%.3f", getMean(array, ARRAY_SIZE));

    return 0;
}
