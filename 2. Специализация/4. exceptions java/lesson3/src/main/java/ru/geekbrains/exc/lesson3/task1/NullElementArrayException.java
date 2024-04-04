package ru.geekbrains.exc.lesson3.task1;

public class NullElementArrayException extends NullPointerException {

    private final int index;

    public int getIndex() {
        return index;
    }

    public NullElementArrayException(String s, int index) {
        super(s);
        this.index = index;
    }
}
