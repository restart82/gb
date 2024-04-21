#include <stdio.h>

// Определить количество положительных элементов квадратной матрицы,
// превышающих по величине среднее арифметическое всех элементов главной
// диагонали. Реализовать функцию среднее арифметическое главной
// диагонали.

#define MATRIX_BUFER 10

int getMeanDiagonal(int size, int matr[MATRIX_BUFER][MATRIX_BUFER])
{
    int result = 0;
    for (int i = 0; i < size; i++)
    {
        result += matr[i][i];
    }
    return result / size;
}

int getNumber(int size, int matr[MATRIX_BUFER][MATRIX_BUFER])
{
    int result = 0;
    int mean = getMeanDiagonal(size, matr);
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            if (matr[i][j] > mean && matr[i][j] > 0)
            {
                result++;
            }
        }
    }
    return result;
}

void printMatrix(int size, int matr[MATRIX_BUFER][MATRIX_BUFER])
{
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            printf("%d\t", matr[i][j]);
        }
        printf("\n\n");
    }
}

int main(int argc, char const *argv[])
{
    int matrix[MATRIX_BUFER][MATRIX_BUFER] =    {    
                                                    {1, 1, 1, 1, 1},
                                                    {2, 2, 2, 2, 2},
                                                    {3, 3, 3, 3, 3},
                                                    {4, 4, 4, 4, 4},
                                                    {5, 5, 5, 5, 5}
                                                };
    int matrixSize = 5;
    // printMatrix(matrixSize, matrix);
    printf("%d", getNumber(matrixSize, matrix));
    return 0;
}
