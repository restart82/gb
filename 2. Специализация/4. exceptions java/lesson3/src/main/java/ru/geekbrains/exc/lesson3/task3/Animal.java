package ru.geekbrains.exc.lesson3.task3;

public abstract class Animal {

    protected String name;

    public String getName() {
        return name;
    }

    protected Animal(String name) {

        this.name = name;

    }

    @Override
    public String toString() {
        return name;
    }

    abstract void swim(int distance) throws AnimalSwimException;
    abstract void run(int distance) throws AnimalRunException;


}
