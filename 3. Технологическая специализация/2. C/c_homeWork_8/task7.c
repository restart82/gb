#include <stdio.h>

// Известно, что шахматная доска имеет размерность 8х8 и состоит из клеток 2х
// цветов, например, черного и белого (см. рисунок). Каждая клетка имеет
// координату, состоящую из буквы и цифры. Горизонтальное расположение
// клетки определяется буквой от A до H, а вертикальное – цифрой от 1 до 8.
// Заметим, что клетка с координатой А1 имеет черный цвет. Требуется по
// заданной координате определить цвет клетки.

const int chessboardSize = 8;

typedef enum
{
    WHITE,
    BLACK
}cellColor_t;

void initChessboard(cellColor_t board[chessboardSize][chessboardSize])
{
    cellColor_t color;
    for (int i = 0; i < chessboardSize; i++)
    {
        for (int j = 0; j < chessboardSize; j++)
        {
            if ((i + j) % 2)
            {
                color = WHITE;
            }
            else
            {
                color = BLACK;
            }
            board[i][j] = color;
        }
    }
}

int getCellBoardRow(char str[])
{
    return (int) (str[0] - 'A');
}

int getCellBoardCol(char str[])
{
    return (int) (str[1] - '0' - 1);
}

int main(int argc, char const *argv[])
{
    cellColor_t chessboard[chessboardSize][chessboardSize];
    initChessboard(chessboard);
    
    char cell[2];
    scanf("%[A-H]%[1-8]", cell, cell + 1);
    int row = getCellBoardRow(cell);
    int col = getCellBoardCol(cell);

    switch (chessboard[row][col])
    {
    case BLACK:
        printf("BLACK");
        break;
    case WHITE:
        printf("WHITE");
        break;
    }

    return 0;
}
