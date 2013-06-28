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

    private int value = 0;

    public synchronized int getValue() {
        return value;
    }

    public synchronized void increment() {
        value++;
    }

    public synchronized void decrement() {
        value--;
    }
}
