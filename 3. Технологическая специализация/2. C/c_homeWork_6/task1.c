#include <stdio.h>

// Дано натуральное число N. Выведите все его цифры по одной, в прямом
// порядке, разделяя их пробелами или новыми строками. Необходимо
// реализовать рекурсивную функцию.

int findFirstDigit(int number)
{
    while (number > 9)
    {
        number /= 10;    
    }
    return number;
}

int removeFirstDigit(int number)
{
    int order = 1, buf = number;
    while (number > 9)
    {
        order *= 10;
        number /= 10;
    }
    return buf % order;
}

void print_num(int num)
{
    int n = findFirstDigit(num);
    num = removeFirstDigit(num);
    printf("%d ", n);
    if (num > 0)
    {
        print_num(num);
    }
}

int main(int argc, char const *argv[])
{
    int number;
    scanf("%d", &number);

    print_num(number);

    return 0;
}
