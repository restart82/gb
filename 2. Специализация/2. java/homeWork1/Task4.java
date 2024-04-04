import java.io.*;
public class Task4 {
    public static void main(String[] args) throws Exception {
        FileReader fr = new FileReader("input.txt");
        int c;
        while ((c = fr.read()) != -1) {
            char ch = (char) c;
            if (ch == '\n') {
                System.out.print(ch);
            } else {
                System.out.print(ch);
            }
        }
    }
}
