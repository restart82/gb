#include <stdio.h>

// Считать массив из 10 элементов и отобрать в другой массив все числа, у
// которых вторая с конца цифра (число десятков) – ноль.

#define ARRAY_SIZE 10

void scanArray(int arr[], int size)
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

int getSecondArray(int arr_1[], int arr_2[], int size_1)
{
    int j = 0;
    for (size_t i = 0; i < size_1; i++)
    {
        if ((arr_1[i] / 10) % 10 == 0)
        {
            arr_2[j] = arr_1[i];
            j++;
        }
    }
    return j;
}

int main(int argc, char const *argv[])
{
    int arrayA[ARRAY_SIZE], arrayB[ARRAY_SIZE];
    scanArray(arrayA, ARRAY_SIZE);
    int arraybSize = getSecondArray(arrayA, arrayB, ARRAY_SIZE);
    printArray(arrayB, arraybSize);
    return 0;
}
