#include <stdio.h>

// Дан массив из 10 элементов. Определить, какое число в массиве встречается
// чаще всего. Гарантируется, что такое число ровно 1.

#define ARRAY_SIZE 10

void scanArray(int arr[], int size)
{
    for (size_t i = 0; i < size; i++)
    {
        scanf("%d", arr + i);
    }
}

int getPopularNumber(int arr[], int size)
{
    int maxIndex = 0, quantity = 0, maxQuantity = 0;
    for (int i = 0; i < size; i++)
    {
        quantity = 0;
        for (int j = 0; j < size; j++)
        {
            if (arr[i] == arr[j])
            {
                quantity++;
            }
        }
        if (quantity > maxQuantity)
        {
            maxIndex = i;
        }
    }
    return arr[maxIndex];
}

int main(int argc, char const *argv[])
{
    int arrayA[ARRAY_SIZE];
    scanArray(arrayA, ARRAY_SIZE);
    printf("%d", getPopularNumber(arrayA, ARRAY_SIZE));
    return 0;
}
