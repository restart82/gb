package ru.geekbrains.exc.lesson2.task1;

public abstract class CustomArrayException extends Exception {

    private final int x;
    private final int y;


    public int getX() {
        return x;
    }

    public int getY() {
        return y;
    }

    public CustomArrayException(String message, int x, int y) {
        super(message);
        this.x = x;
        this.y = y;
    }

    public CustomArrayException(String message, Throwable throwable, int x, int y) {
        super(message, throwable);
        this.x = x;
        this.y = y;
    }
}
