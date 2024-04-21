#include "task.h"

void swip(char* string, int c1, int c2)
{
    char temp = *(string + c1);
    *(string + c1) = *(string + c2);
    *(string + c2) = temp;
}

void swipLetters(char* string)
{
    printf("%s\n", string);
    int i = 0, c1_index, c2_index;

    while (string[i] != '\0')
    {
        while (string[i] == ' ')
        {
            i++;
        }
        c1_index = i++;
        while (string[i] == ' ')
        {
            i++;
        }
        if (string)
        c2_index = i++;
        if (string[c2_index] != '\0')
            swip(string, c1_index, c2_index);
    }

    printf("%s\n", string);
}