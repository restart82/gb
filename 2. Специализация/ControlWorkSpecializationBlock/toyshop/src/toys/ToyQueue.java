package toys;

import java.util.Iterator;
import java.util.PriorityQueue;

public class ToyQueue implements Iterable<Toy>{

    private PriorityQueue<Toy> queue;
    public ToyQueue() {
        queue = new PriorityQueue<>(new ToyComparatorByID<>());
    }

    public PriorityQueue<Toy> getQueue() {
        return queue;
    }

    public void add(Toy toy) {
        queue.add(toy);
    }

    public void delete(Toy toy) {
        queue.remove(toy);
    }

    public int size() {
        return queue.size();
    }

    @Override
    public Iterator<Toy> iterator() {
        return queue.iterator();
    }
}
