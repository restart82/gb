#include <stdio.h>

// Дана строка из английских символов, пробелов и знаков препинания. В конце
// строки символ точка. Необходимо реализовать рекурсивную функцию,
// которая считывает данную строку со стандартного потока ввода и возвращает
// целое число – количество символов 'a' в данной строке.

int acounter(void)
{
    static int counter = 0;
    char c = getchar();
    if (c != '.')
    {
        if (c == 'a')
        {
            counter++;
        }
        return acounter();
    }
    else
    {
        return counter;
    }
}

int main(int argc, char const *argv[])
{
    printf("%d", acounter());   
    return 0;
}
