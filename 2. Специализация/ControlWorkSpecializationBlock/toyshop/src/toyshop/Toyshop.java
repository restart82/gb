package toyshop;

import exceptions.ArraySizeException;
import exceptions.FileInitException;
import fileWriter.MyFileWriter;
import toys.Toy;
import toys.ToyQueue;

import java.util.Random;

public class Toyshop implements Lottery {

    private int toyID = 1;
    private int getCounter = 1;
    private ToyQueue toyQueue;

    public Toyshop() {
        toyQueue = new ToyQueue();
    }

    public String getInfo() {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.append("\n\n\n\nСписок игрушек:\n\n");
        for (Toy toy: toyQueue) {
            stringBuilder.append(toy);
        }
        return stringBuilder.toString();
    }

    public Toy findToyByID(int id) {
        Toy result = null;
        for (Toy toy: toyQueue) {
            if (toy.getID() == id) {
                result = toy;
            }
        }
        return result;
    }

    public void writeInFile(String string) throws FileInitException{
        MyFileWriter fileWriter = new MyFileWriter();
        fileWriter.write(string);
    }

    public void fileInit() {
        MyFileWriter fileWriter = new MyFileWriter();
        fileWriter.startWrite();
    }

    public int getSize() {
        return toyQueue.size();
    }

    public int getToyTotalQuantity () {
        int result = 0;
        for (Toy toy: toyQueue) {
            result += toy.getQuantity();
        }
        return result;
    }

    @Override
    public void put(String string) {
        String[] parseString = string.split(" ");
        if (parseString.length != 3) {
            throw new ArraySizeException("Некорректная длина посылки", parseString.length);
        }
        if (!isDigit(parseString[0]) || !isDigit(parseString[2])) {
            throw new RuntimeException("Должна быть цифра");
        }
        int weight = Integer.parseInt(parseString[0]);
        String name = parseString[1];
        int quantity = Integer.parseInt(parseString[2]);
        Toy toy = new Toy(toyID++, weight, name, quantity);
        toyQueue.add(toy);
    }

    @Override
    public void changeWeight(int id, int newWeight) {
        try {
            Toy toy = findToyByID(id);
            toy.setWeight(newWeight);
        } catch (NullPointerException e) {
            System.out.println("Нет игрушки с ID: " + id);
        }
    }

    @Override
    public void get() throws FileInitException{
        // Определяем id
        int winner = getWinnerID();
        // Записываем в файл
        String message = String.format("Победитель #%d:\t%s\n",
                getCounter++, findToyByID(winner).getName());
        System.out.printf(message);
        writeInFile(message);
        // Убираем победителя из общего списка
//        toyQueue.delete(findToyByID(winner));
        removeToy(findToyByID(winner));
    }

    private static boolean isDigit(String str) {
        try {
            Double.parseDouble(str);
            return true;
        } catch(NumberFormatException e){
            return false;
        }
    }

    private int getWinnerID () {
        int winner = 0;
        int[] numbers = new int[toyQueue.size()];
        int[] points = new int[toyQueue.size()];
        int pointsSum = 0;
        int k = 0;
        for (Toy toy: toyQueue) {
            numbers[k] = toy.getID();
            points[k] = toy.getWeight();
            pointsSum += points[k++];
        }
        Random random = new Random();
        int index = random.nextInt(pointsSum);
        for (int i = 0; i < points.length; i++) {
            index -= points[i];
            if(index < 0) {
                winner = numbers[i];
                break;
            }
        }
        return winner;
    }

    private void removeToy(Toy toy) {
        int newQuantity = toy.getQuantity() - 1;
        if (newQuantity == 0) {
            toyQueue.delete(toy);
        } else {
            toy.setQuantity(newQuantity);
        }
    }
}
