package ru.geekbrains.exc.lesson3.task3;

import java.util.Random;

public class Program {

    /**
     Задача 3:
     =========
     Спроектировать серию классов для работы с животным. Защитить состояние и поведение
     объекта используя исключения.
     */
    public static void main(String[] args) {

        try
        {
            Animal animal = Cat.create("Персик");
            Random random = new Random();
            for (int i = 0; i < 10; i++){
                int j = random.nextInt(2);
                try
                {
                    switch (j){
                        case 0 -> {
                            animal.swim(i *10);
                            System.out.println("Кот успешно пробежал дистанцию.");
                        }
                        case 1 -> {
                            animal.run(i *10);
                            System.out.println("Кот успешно пробежал дистанцию.");
                        }
                    }
                }
                catch (AnimalRunException e){
                    System.out.printf("Исключение при попытке %s пробежать %d метров.\n",
                            e.getName(), e.getDistance());
                }
                catch (AnimalSwimException e){
                    System.out.printf("Исключение при попытке %s проплыть %d метров.\n",
                            e.getName(), e.getDistance());
                }

            }
        }
        catch (AnimalNameException e){
            System.out.println(e.getMessage());
        }

    }

}
