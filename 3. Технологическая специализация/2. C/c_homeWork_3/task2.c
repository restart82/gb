#include <stdio.h>

// Ввести пять чисел и вывести наименьшее из них
// Нужно напечатать наименьшее число

#define NUMBER_OF_QUANTITY  5

int main(void)
{
    int number[NUMBER_OF_QUANTITY];
    scanf(  "%d %d %d %d %d",
            &number[0],
            &number[1],
            &number[2],
            &number[3],
            &number[4]);

    int min = number[0];
    for (int i = 1; i < NUMBER_OF_QUANTITY; i++)
    {
        if (number[i] < min)
        {
            min = number[i];
        }
    }

    printf("%d\n", min);

    return 0;
}