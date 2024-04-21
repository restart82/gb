#include <stdio.h>

// Считать массив из 12 элементов и выполнить циклический сдвиг ВПРАВО на 4
// элемента.

#define ARRAY_SIZE 12

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

void shiftArray(int arr[], int size)
{
    int temp = arr[size - 1];
    for (size_t i = size - 1; i > 0; i--)
    {
        arr[i] = arr[i - 1];
    }
    arr[0] = temp;
}

int main(int argc, char const *argv[])
{
    int array[ARRAY_SIZE];
    scanArrray(array, ARRAY_SIZE);
    shiftArray(array, ARRAY_SIZE);
    shiftArray(array, ARRAY_SIZE);
    shiftArray(array, ARRAY_SIZE);
    shiftArray(array, ARRAY_SIZE);
    printArray(array, ARRAY_SIZE);

    return 0;
}
