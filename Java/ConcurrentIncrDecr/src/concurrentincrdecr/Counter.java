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

    public int value() {
        return c;
    }

    public void increment() {
        c++;
    }

    public void decrement() {
        c--;
    }
}
