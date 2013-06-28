/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package concurrentincrdecr;

/**
 *
 * @author Robert Impey
 */
public class CounterRunner implements Runnable {

    public static final int CYCLES = 10000000;
    
    private int id;
    private Counter counter;
    private boolean increment;

    public CounterRunner(int id, Counter counter, boolean increment) {
        this.id = id;
        this.counter = counter;
        this.increment = increment;
    }

    @Override
    public void run() {
        int mistakes = 0;

        for (int i = 0; i < CYCLES; i++) {
            int oldValue = counter.getValue();
            int expectedValue = oldValue;
            int newValue;

            if (increment) {
                counter.increment();
                newValue = counter.getValue();
                expectedValue++;
            } else {
                counter.decrement();
                newValue = counter.getValue();
                expectedValue--;
            }

            if (newValue != expectedValue) {
                mistakes++;
            }
        }

        System.out.printf("%d, %d, %s\n", id, mistakes, (increment ? "Increment" : "Decrement"));
    }
}
