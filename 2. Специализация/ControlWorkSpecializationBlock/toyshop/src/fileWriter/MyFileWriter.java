package fileWriter;

import exceptions.FileInitException;

import java.io.FileWriter;
import java.io.IOException;
import java.text.SimpleDateFormat;
import java.util.Date;

public class MyFileWriter {
    private static final String DATA_FILE = "src/lottery.txt";
    private static boolean fileInitFlag = false;
    private final Date date = new Date();
    private final SimpleDateFormat dateFormat = new SimpleDateFormat("dd.MM.yyyy (hh:mm:ss)");

    public void startWrite() {
        try (FileWriter fileWriter = new FileWriter(DATA_FILE)){
            String strDate = dateFormat.format(date);
            fileWriter.write("Розыгрыш от " + strDate + "\n-------------------------------------------\n");
            fileInitFlag = true;
        } catch (IOException e) {
            System.out.println("Ошибка при записи в файл");
            e.printStackTrace();
        }
    }

    public void write(String string) throws FileInitException {
        if (!fileInitFlag) {
            throw new FileInitException("Файла не проинициализирован\nВоспользуйтесь методом fileInit");
        }
        try (FileWriter fileWriter = new FileWriter(DATA_FILE, true)){
            fileWriter.append(string);
        } catch (IOException e) {
            System.out.println("Ошибка при записи в файл");
            e.printStackTrace();
        }
    }
}
