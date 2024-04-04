package ru.geekbrains.exc.lesson3.task2;

public class Program {

    /**
     Задача 2:
     =========
     Создайте класс Счетчик, у которого есть метод add(), увеличивающий
     значение внутренней int переменной на 1. Сделайте так, чтобы с объектом
     такого типа можно было работать в блоке try-with-resources. Подумайте, что
     должно происходить при закрытии этого ресурса? Напишите метод для
     проверки, закрыт ли ресурс. При попытке вызвать add() у закрытого
     ресурса, должен выброситься IOException.
     */

    public static void main(String[] args) {

        try (Counter counter = new Counter(1000))
        {
            counter.add();
            counter.add();
            counter.add();
        }
        catch (CloseCounterException e){
            System.out.println(e.getMessage());
        }

    }

}
