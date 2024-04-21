#include <stdio.h>
#include <stdbool.h>

// Считать массив из 10 элементов и отсортировать его по последней цифре

#define ARRAY_SIZE 10

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

void swap(int* pa, int* pb)
{
    int temp = *pa;
    *pa = *pb;
    *pb = temp;
}

void sortArray(int arr[], int size)
{
    int i = 0;
    bool flag;
    do
    {
        flag = false;
        for (int j = size - 2; j >= i; j--)
        {
            if (arr[j] % 10 > arr[j + 1] % 10)
            {
                swap(&arr[j], &arr[j + 1]);
                flag = true;
            }
        }
        i++;
    } while (flag);
    
}

int main(int argc, char const *argv[])
{
    int array[ARRAY_SIZE];
    scanArrray(array, ARRAY_SIZE);
    sortArray(array, ARRAY_SIZE);
    printArray(array, ARRAY_SIZE);

    return 0;
}
