/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package concurrentincrdecr;

import java.util.LinkedList;
import java.util.List;

/**
 *
 * @author Robert
 */
public class ConcurrentIncrDecr {

    public static final int THREADS = 1;
    public static final int CYCLES = 1000000;

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        List<CounterRunner> counterRunners = new LinkedList<>();

        Counter counter = new Counter();
        boolean increment = true;

        for (int i = 0; i < THREADS; i++) {
            counterRunners.add(new CounterRunner(i, counter, increment));
            increment = !increment;
        }

        System.out.printf(
                "ID, Mistakes, Increment, Threads, %d, Cycles, %d\n",
                THREADS,
                CYCLES);
        for (CounterRunner counterRunner : counterRunners) {
            (new Thread(counterRunner)).start();
        }

        System.out.printf("Final counter value, %d\n", counter.value());
    }
}
