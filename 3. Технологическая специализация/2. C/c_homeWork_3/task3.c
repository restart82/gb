#include <stdio.h>
#include <stdbool.h>

// Ввести три числа и определить, верно ли, что они вводились в порядке
// возрастания.

#define NUMBER_OF_QUANTITY  3

int main(void)
{
    int number[NUMBER_OF_QUANTITY];
    bool flag = false;

    scanf(  "%d %d %d",
            &number[0],
            &number[1],
            &number[2]);

    for (int i = 1; i < NUMBER_OF_QUANTITY; i++)
    {
        flag = (number[i] > number[i - 1]);
        if (!flag)
        {
            break;
        }
    }

    flag ? printf("YES") : printf("NO");

    return 0;
}