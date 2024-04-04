package toys;

import java.util.Comparator;

public class ToyComparatorByID<T extends ToyItem> implements Comparator<T> {
    @Override
    public int compare(T o1, T o2) {
        return Integer.compare(o1.getID(), o2.getID());
    }
}
