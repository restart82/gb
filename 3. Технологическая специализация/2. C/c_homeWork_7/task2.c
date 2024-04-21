#include <stdio.h>

// Ввести с клавиатуры массив из 5 элементов, найти минимальный из них

#define ARRAY_SIZE 5

void scanArrray(int arr[], int size)
{
    for (size_t i = 0; i < size; i++)
    {
        scanf("%d", arr + i);
    }
}

int getMin(int arr[], int size)
{
    int result = arr[0];
    for (size_t i = 0; i < size - 1; i++)
    {
        if (arr[i] > arr[i + 1])
        {
            result = arr[i + 1];
        }
    }
    return result;
}

int main(int argc, char const *argv[])
{
    int array[ARRAY_SIZE];
    scanArrray(array, ARRAY_SIZE);
    printf("%d", getMin(array, ARRAY_SIZE));

    return 0;
}
