package ru.geekbrains.exc.lesson2.task1;

public class MyArraySizeException extends  CustomArrayException{
    public MyArraySizeException(String message, int x, int y) {
        super(message, x, y);
    }

    public MyArraySizeException(String message, Throwable throwable, int x, int y) {
        super(message, throwable, x, y);
    }
}
