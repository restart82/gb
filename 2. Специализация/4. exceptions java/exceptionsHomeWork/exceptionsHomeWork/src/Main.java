import java.io.FileWriter;
import java.io.IOException;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

//        String input = "Фамилия1 Имя2 Отчество 24.06.1998 789456123 m";
        Scanner scanner = new Scanner(System.in);
        System.out.println("Введите строку формата (Фамилия Имя Отчество датарождения номертелефона пол):");
        String input = scanner.nextLine();

        try {
            DataPacket dataPacket = DataPacket.create(input);
            System.out.println(dataPacket);
            try (FileWriter fileWriter = new FileWriter(dataPacket.getFirstName() + ".txt", true)){
                fileWriter.write(dataPacket + "\n");
                System.out.printf("Успешно записано в файл %s.txt", dataPacket.getFirstName());
            } catch (IOException e) {
                System.out.println("Ошибка при записи в файл");
                e.printStackTrace();
            }
        } catch (PacketSizeException e) {
            System.out.println("Неверная длина пакета!");
            System.out.printf("Введено %d атрибутов, а надо %d", e.getPacketSize(), 6);
        }
    }
}
