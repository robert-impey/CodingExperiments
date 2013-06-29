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

    public static final int CYCLES = 1000000;
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
            int expectedValue, currentValue;
            
            synchronized (counter) {
                expectedValue = counter.value() + (increment ? 1 : -1);

                if (increment) {
                    counter.increment();
                } else {
                    counter.decrement();
                }

                currentValue = counter.value();
            }
            
            if (currentValue != expectedValue) {
                mistakes++;
            }
        }

        System.out.printf(
                "%d, %d, %s\n",
                id,
                mistakes,
                (increment ? "Increment" : "Decrement"));
    }
}
