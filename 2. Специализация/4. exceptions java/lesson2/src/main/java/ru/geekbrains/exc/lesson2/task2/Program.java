package ru.geekbrains.exc.lesson2.task2;

import java.io.FileWriter;
import java.io.IOException;
import java.util.Random;

public class Program {

    private static Random random = new Random();


    /**
     *  Задача 2
     *  ========
     *  Запишите в файл следующие строки:
     *
     *  Анна=4
     *  Елена=5
     *  Марина=6
     *  Владимир=8
     *  Константин=10
     *  Иван=4
     */
    public static void main(String[] args) {
        prepareFile();
    }

    static void prepareFile(){
        try (FileWriter fileWriter = new FileWriter("names.txt")) {

            fileWriter.write("Анна=4\n");
            fileWriter.write("Елена=5\n");
            fileWriter.write("Марина=6\n");
            if (random.nextInt(2) == 0)
                throw new Exception("Непредвиденное исключение.");
            fileWriter.write("Владимир=8\n");
            fileWriter.write("Константин=10\n");
            fileWriter.write("Иван=4\n");
        }
        catch (IOException e){
            e.printStackTrace();
        }
        catch (Exception e){
            e.printStackTrace();
        }
    }

    static void prepareFile_old(){

        FileWriter fileWriter = null;
        try {
           fileWriter = new FileWriter("names.txt");
            fileWriter.write("Анна=4\n");
            fileWriter.write("Елена=5\n");
            fileWriter.write("Марина=6\n");
            if (random.nextInt(2) == 0)
                throw new Exception("Непредвиденное исключение.");
            fileWriter.write("Владимир=8\n");
            fileWriter.write("Константин=10\n");
            fileWriter.write("Иван=4\n");
        }
        catch (IOException e){
            e.printStackTrace();
        }
        catch (Exception e){
            e.printStackTrace();
        }
        finally {
            try {
                fileWriter.close();
            }
            catch (Exception e){

            }

        }
    }

}














