package ru.geekbrains.exc.lesson3.task2;

import java.io.IOException;

public class CloseCounterException extends IOException {

    public CloseCounterException(String message) {
        super(message);
    }
}
