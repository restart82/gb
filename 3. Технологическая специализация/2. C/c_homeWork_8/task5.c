#include <stdio.h>

// Составить функцию, которая меняет в массиве минимальный и максимальный
// элемент местами. Прототип функции
// void change_max_min(int size, int a[])


void change_max_min(int size, int a[])
{
    int maxIndex = 0, minIndex = 0;
    for (int i = 1; i < size; i++)
    {
        if (a[i] > a[maxIndex])
        {
            maxIndex = i;
        }
        if (a[i] < a[minIndex])
        {
            minIndex = i;
        }
    }
    int temp = *(a + minIndex);
    *(a + minIndex) = *(a + maxIndex);
    *(a + maxIndex) = temp;
}


/*
#define ARRAY_BUFER 100

void print_array(int number, int arr[])
{
    for (size_t i = 0; i < number; i++)
    {
        printf("%d ", *(arr + i));
    }
    printf("\n");
}

int main(int argc, char const *argv[])
{
    int array[ARRAY_BUFER] = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
    int arrSize = 10;
    print_array(arrSize, array);
    change_max_min(arrSize, array);
    print_array(arrSize, array);

    return 0;
}
*/