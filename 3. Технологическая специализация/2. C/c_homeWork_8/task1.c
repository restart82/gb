#include <stdio.h>

// Написать только одну функцию, которая сортирует массив по возрастанию.
// Необходимо реализовать только одну функцию, всю программу составлять не
// надо.
// Строго согласно прототипу. Имя функции и все аргументы должны быть:
// void sort_array(int size, int a[])
// Всю программу загружать не надо, только одну эту функцию. Можно просто
// закомментировать текст всей программы, кроме данной функции.

void sort_array(int size, int a[])
{
    int temp = 0;
    for (int i = 0; i < size; i++)
    {
        for (int j = size - 2; j >= i; j--)
        {
            if (a[j] > a[j + 1])
            {
                temp = *(a + j);
                *(a + j) = *(a + j + 1);
                *(a + j + 1) = temp;
            }
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
    int array[ARRAY_BUFER] = {20, 19, 4, 3, 2, 1, 18, 17, 13, 12, 11, 16, 15, 14, 10, 9, 8, 7, 6, 5};
    int arrSize = 20;
    // int array[ARRAY_BUFER] = {5, 4, 3, 2, 1};
    // int arrSize = 5;
    print_array(arrSize, array);
    sort_array(arrSize, array);
    print_array(arrSize, array);

    return 0;
}
*/