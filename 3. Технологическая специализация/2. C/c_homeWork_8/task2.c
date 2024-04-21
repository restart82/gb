#include <stdio.h>
#include <stdbool.h>

// Написать только одну функцию, которая ставит в начало массива все четные
// элементы, а в конец – все нечетные. Не нарушайте порядок следования чисел
// между собой. Строго согласно прототипу:
// void sort_even_odd(int n, int a[])


void sort_even_odd(int n, int a[])
{
    bool breakFlag = true;
    int temp;
    for (int i = 0; i < n; i++)
    {
        int j = i;
        while (a[j] % 2 == 1)
        {
            if (j == n - 1)
            {
                breakFlag = false;
                break;
            }
            j++;
        }
        if (breakFlag)
        {
            temp = a[j];
            for (int k = j; k > i; k--)
            {
                a[k] = a[k - 1];
            }
            a[i] = temp;
        }
    }
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
    int array[ARRAY_BUFER] = {20, 19, 18, 17, 16, 15, 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1};
    int arrSize = 20;
    // int array[ARRAY_BUFER] = {1, 0, 1, 0, 1};
    // int arrSize = 5;
    print_array(arrSize, array);
    sort_even_odd(arrSize, array);
    print_array(arrSize, array);

    return 0;
}
*/