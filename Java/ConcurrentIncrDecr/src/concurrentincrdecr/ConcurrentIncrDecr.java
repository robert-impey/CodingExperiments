/*
 * The main method of the package.
 */
package concurrentincrdecr;

import java.util.LinkedList;
import java.util.List;
import java.util.concurrent.CountDownLatch;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author Robert Impey
 */
public class ConcurrentIncrDecr {

    public static final int THREADS = 100;
    public static final int CYCLES = 1000000;

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        List<CounterRunner> counterRunners = new LinkedList<>();

        Counter counter = new Counter();
        boolean increment = true;

        CountDownLatch countDownLatch = new CountDownLatch(THREADS);

        /*
         * Create the runner objects.
         * Because they count up and down in turn, if we have an even
         * number of threads that all complete the same number of cycles,
         * then the end count must be 0.
         */
        for (int i = 0; i < THREADS; i++) {
            counterRunners.add(new CounterRunner(i, counter, increment, countDownLatch));
            increment = !increment;
        }

        System.out.printf(
                "ID, Mistakes, Increment, Threads, %d, Cycles, %d\n",
                THREADS,
                CYCLES);

        /*
         * Start the threads.
         */
        for (CounterRunner counterRunner : counterRunners) {
            (new Thread(counterRunner)).start();
        }

        /*
         * Don't print off the final count until all the threads have
         * completed.
         */
        try {
            countDownLatch.await();
            System.out.printf("Final counter value, %d\n", counter.value());
        } catch (InterruptedException ex) {
            Logger.getLogger(ConcurrentIncrDecr.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
}
