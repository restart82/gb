package ru.geekbrains.exc.lesson3.task3;

public class AnimalRunException extends AnimalActionException {
    public AnimalRunException(String message, String name, int distance) {
        super(message, name, distance);
    }
}
