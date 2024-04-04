public class PacketSizeException extends Exception{


    private final int packetSize;

    public PacketSizeException(String m, int packetSize) {
        super(m);
        this.packetSize = packetSize;
    }

    public int getPacketSize() {
        return packetSize;
    }
}
