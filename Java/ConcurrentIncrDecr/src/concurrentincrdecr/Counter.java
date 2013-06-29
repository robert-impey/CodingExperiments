/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package concurrentincrdecr;

/**
 *
 * @author Robert
 */
public class Counter {

    private int c = 0;

    public synchronized int value() {
        return c;
    }

    public synchronized void increment() {
        c++;
    }

    public synchronized void decrement() {
        c--;
    }
}
