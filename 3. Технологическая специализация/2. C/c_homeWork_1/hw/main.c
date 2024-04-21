#include <stdio.h>

/*

Задание 1. Вывести на экран “Hello world!”
Задание 2. Вывести на экран текст "лесенкой"
			Let’s
				go
					to walk
Задание 3. Вывести на экран рисунок из букв
			   *
			  ***
			 *****
			*******
			 HH HH
			 ZZZZZ
Задание 4 * .Нарисовать соты
			 __    __ 
			/  \__/  \
			\__/  \__/
			/  \__/  \
			\__/  \__/

*/

void printSpace(int number)
{
	for (int i = 0; i < number; i++)
	{
		printf("\n");
	}
}

void printStairs(char text[])
{
	static int stage = -1;
	stage++;
	for (int i = 0; i < stage; i++)
	{
		printf("\t");
	}
	printf(text);
	printf("\n");
}

void printArrow()
{
	printf("   *   \n");
	printf("  ***  \n");
	printf(" ***** \n");
	printf("*******\n");
	printf(" HH HH \n");
	printf(" ZZZZZ \n");
}

void printHoneycomb()
{
	printf(" __    __    \n");
	printf("/  \\__/  \\ \n");
	printf("\\__/  \\__/ \n");
	printf("/  \\__/  \\ \n");
	printf("\\__/  \\__/ \n");
}


int main(void)
{
	// 1.
	printf("Hello world!");
	printSpace(4);

	// 2.
	printStairs("Let’s");
	printStairs("go");
	printStairs("to walk");
	printSpace(3);

	// 3.
	printArrow();
	printSpace(3);

	// 4.
	printHoneycomb();

	return 0;
}