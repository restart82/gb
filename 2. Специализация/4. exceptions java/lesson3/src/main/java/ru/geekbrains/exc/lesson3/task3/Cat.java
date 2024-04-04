package ru.geekbrains.exc.lesson3.task3;

public class Cat extends Animal {
    private Cat(String name) {
        super(name);
    }

    @Override
    void swim(int distance) throws AnimalSwimException{
        throw new AnimalSwimException("Котик не умеет плавать", name, distance);
    }

    @Override
    void run(int distance) throws AnimalRunException{
        if (distance > 60){
            throw new AnimalRunException("Котику тяжело бежать", name, distance);
        }
        //TODO: ...
    }

    public static Cat create(String name) throws AnimalNameException{
        if (name == null || name.length() < 3)
            throw new AnimalNameException("Некорректное имя животного", name);
        return new Cat(name);
    }

}
