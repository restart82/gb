#include <stdio.h>
#include <stdbool.h>

/*Ввести три числа, найти их сумму
Нужно напечатать сумму трех чисел*/

bool checkNumber(int number)
{
    return ((number < 10000) && (number > 999));
}

int main(void)
{
    int number;
    scanf("%d", &number);

    if (checkNumber(number))
    {
        int order = 1;
        float sum = 0;

        for (int i = 0; i < 4; i++)
        {
            sum += (number / order) % 10;
            order *= 10;
        }
        printf("%.2f", sum / 4);
    }
    else
    {
        printf("число не 4-хзначное :(");
    }
    
    
    return 0;
}