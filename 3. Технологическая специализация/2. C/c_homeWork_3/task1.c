#include <stdio.h>

// Ввести пять чисел и вывести наибольшее из них
// Нужно напечатать наибольшее число

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

    int max = number[0];
    for (int i = 1; i < NUMBER_OF_QUANTITY; i++)
    {
        if (number[i] > max)
        {
            max = number[i];
        }
    }

    printf("%d\n", max);

    return 0;
}