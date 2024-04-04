package toyshop;

import exceptions.FileInitException;

public interface Lottery {
//    Представлены методы, обязательные по ТЗ
    /**
     * Метод добавляет элемент типа Toy в коллекцию PriorityQueue
     */
    void put(String string);

    /**
     * Метод позволяет изменить вес игрушки
     */
    void changeWeight(int id, int newWeight);

    /**
     * Метод возвращает ID победителя розыгрыша,
     * записывает победителя в файл,
     * убирает победителя из коллекции PriorityQueue
     */
    void get() throws FileInitException;
}
