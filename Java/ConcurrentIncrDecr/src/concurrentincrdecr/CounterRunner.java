package concurrentincrdecr;

import java.util.concurrent.CountDownLatch;

/**
 *
 * @author Robert Impey
 */
public class CounterRunner implements Runnable {
    private final int id;
    private final Counter counter;
    private final boolean increment;
    private final CountDownLatch countDownLatch;

    public CounterRunner(int id, Counter counter, boolean increment, CountDownLatch countDownLatch) {
        this.id = id;
        this.counter = counter;
        this.increment = increment;
        this.countDownLatch = countDownLatch;
    }

    @Override
    public void run() {
        int mistakes = 0;

        for (int i = 0; i < ConcurrentIncrDecr.CYCLES; i++) {
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
        
        countDownLatch.countDown();
    }
}
