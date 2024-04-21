#include <stdio.h>
#include <string.h>
#include <stdint.h>
#include <stdlib.h>

void scan1()
{
    char s[10];
    scanf("%9s", s); //считать 9 символов
    printf("%s", s);
}

void scan2()
{
    char s[10], c;
    int i = 0;
    while ((c = getchar()) != '\n' && i < 9)
    {
        s[i++] = c;
    }
    s[i] = '\0';
    i = 0;
    while (s[i])
    {
        putchar(s[i++]);
    }
}

void scan3()
{
    char s[100];
    scanf("%[a-z]", s);
    printf("%s", s);
}

void scan4()
{
    char s1[100], s2[200];
    scanf("%[0-9]=%[a-z]", s1, s2);
    printf("s1 = %s, s2 = %s", s1, s2);
}

void size1()
{
    char st[10] = "Hello";
    printf("sizeof = %u\n", sizeof(st));
    printf("strlen = %u\n", strlen(st));
}

// char* strcpy(char* dst, char* src)
// {
//     char* ptr = dst;
//     while (*dst++ = *src++);
//     return ptr;
// }
void copy1()
{
    char str1[] = {"Hello!"};
    char str2[] = {"World!"};
    printf("%s\n", strcpy(str2, str1));
    printf("%s\n", str2);
}


int chatToHex(char c)
{
    int result = -1;
    if (c >= '0' && c <= '9')
        result = c - '0';
    else if (c >= 'A' && c <= 'F')
        result = c - 'A' + 10;
    else if (c >= 'a' && c <= 'f')
        result = c - 'a' + 10;
    return result;
}
int strToHexMas(char* str, uint8_t* mas)
{
    int result = 0, data = 0, i = 0, index = 0;
    int StrLenght = strlen(str);
    printf("%d\n", StrLenght);
    while (i < StrLenght)
    {
        result = 0;
        data = chatToHex(str[i++]);
        if (data >= 0)
        {
            result = data;
            if (i  < StrLenght)
            {
                data = chatToHex(str[i++]);
                if (data >= 0)
                {
                    result *= 16;
                    result += data;
                }
            }
            mas[index++] = result;
        }
    }
    
    return index;
}
void converter1()
{
    uint8_t arr[10];
    char str[] = "AAa 1 15"; // 0xAA, 0x0A, 0x01, 0x15
    printf("%s\n", str);
    int len = strToHexMas(str, arr);
    printf("%d\n", len);
    for (int i = 0; i < len; i++)
        printf("%02x, ", arr[i]);
}

void mem1()
{
    char dst[30] = "Hello ";
    char src[30] = "GB!!!";
    strcat(dst, src);
    printf("%s\n", dst);
    strcpy(src, dst);
    printf("%s\n", src);

    int n = strlen(src);
    strncpy(dst, src, n-1);
    dst[n-1] = 0;
    printf("%s %d\n", dst, n);
    
    char substr[14] = "GB!";
    char* substr_ptr = strstr(dst, substr);
    if (substr_ptr)
    {
        long pos = substr_ptr - dst;
        printf("Substr index %ld", pos);
    }
    else
    {
        printf("Not found");
    } 
}

void lib1()
{
    char* str = "652.2345brrt   7";
    char* ptr = str;

    int num = atoi(str); // целая часть
    printf("%d\n", num);

    float numf = atof(str);
    printf("%f\n", numf);

    ptr += 15;
    int num3 = atoi(ptr);
    printf("%d\n", num3);
}

void n_array1()
{
    int m[3][3] = {
        {1, 2, 3},
        {4, 5, 6},
        {7, 8, 9}
    };

    int* p1;
    int (*p2)[3];

    p1 = m[1]; // = {4 5 6}
    p1++; // перешли в соседний элемент по арифметике указателей

    p2 = m + 1;
    p2++;

    printf("%d %d", *p1, **p2);
}

int main(int argc, char const *argv[])
{
    // scan1();
    // scan2();
    // scan3();
    // scan4();
    // size1();
    // copy1();
    // converter1();
    // mem1();
    // lib1();
    n_array1();

    return 0;
}
