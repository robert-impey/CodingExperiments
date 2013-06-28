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

    public int getValue() {
        return value;
    }

    public void increment() {
        value++;
    }

    public void decrement() {
        value--;
    }
}
