package concurrentincrdecr;

import java.util.concurrent.atomic.AtomicInteger;

/**
 *
 * @author Robert Impey
 */
public class Counter {

    private AtomicInteger c = new AtomicInteger(0);

    public int value() {
        return c.get();
    }

    public void increment() {
        c.incrementAndGet();
    }

    public void decrement() {
        c.decrementAndGet();
    }
}
