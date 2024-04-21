#include <stdio.h>

// Ввести натуральное число и напечатать все числа от 10 до введенного числа -
// у которых сумма цифр равна произведению цифр

int main(void)
{
    int number;
    scanf("%d", &number);

    for (int i = 10; i <= number; i++)
    {
        int sum = 0, 
            mult = 1,
            num = i;

        while (num > 0)
        {
            sum += num % 10;
            mult *= num % 10;
            num /= 10;
        }

        if (sum == mult)
        {
            printf("%d ", i);
        }
    }

    return 0;
}