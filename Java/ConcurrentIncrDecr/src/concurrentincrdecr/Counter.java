/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package concurrentincrdecr;

import java.util.concurrent.atomic.AtomicInteger;

/**
 *
 * @author Robert
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
