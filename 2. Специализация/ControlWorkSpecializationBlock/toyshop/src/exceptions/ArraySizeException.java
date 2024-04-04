package exceptions;

public class ArraySizeException extends RuntimeException{

    private int size;
    public ArraySizeException(String m, int size) {
        super(m);
        this.size = size;
    }

    public int getSize() {
        return size;
    }
}
