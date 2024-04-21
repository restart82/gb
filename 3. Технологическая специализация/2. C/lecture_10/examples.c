#include <stdio.h>
#include <stdlib.h>

// ----malloc----

void malloc1()
{
    int *p = malloc(sizeof(int));
    if (p != NULL)
    {
        *p = 55;
        printf("%d \n", *p);
    }
    free(p);
}

// ----stack-----

typedef int datatype;
typedef struct list {
    datatype value;
    struct list* next;
}stack;

void push(stack **p, datatype data)
{
    stack *ptmp;
    ptmp = malloc(sizeof(stack));
    ptmp->value = data;
    ptmp->next = *p;
    *p = ptmp;
}

_Bool empty_stack(stack *p)
{
    return p == NULL;
}

datatype pop(stack **p)
{
    stack *ptmp = *p;
    datatype c;
    if (empty_stack(*p))
    {
        exit (1);
    }
    c = ptmp->value;
    *p = ptmp->next;
    free(ptmp);
    return c;
}

void list1()
{
    stack *p = NULL;
    for (size_t i = 0; i <= 5; i++)
    {
        push(&p, i);
    }
    for (size_t i = 0; i <= 5; i++)
    {
        printf("%d\n", pop(&p));
    }
    
}

// ----dinamic array-----

typedef struct stack
{
    datatype* item;
    int size;
    int sp;
}din_stack;

void init_stack(din_stack *st)
{
    st->size = 2;
    st->sp = 0;
    st->item = malloc(st->size * sizeof(datatype));
}

void array1()
{
    din_stack *st;
    init_stack(st);
}

int main(int argc, char const *argv[])
{
    // malloc1();
    // list1();
    array1();
    return 0;
}
