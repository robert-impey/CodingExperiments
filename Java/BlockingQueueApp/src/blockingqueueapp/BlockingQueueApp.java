/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package blockingqueueapp;

import java.util.concurrent.ArrayBlockingQueue;
import java.util.concurrent.BlockingQueue;
import java.util.concurrent.CountDownLatch;

/**
 *
 * @author Robert
 */
public class BlockingQueueApp {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        int numberOfProducers = 100;
        int numberOfMessages = 500;

        int expectedMessagesConsumed = numberOfProducers * numberOfMessages;

        int queueCapacity;
        queueCapacity = 1;
        //queueCapacity = 10;
        //queueCapacity = numberOfProducers * numberOfMessages;
        boolean accessFairness = true;

        BlockingQueue<String> drop;
        drop = new ArrayBlockingQueue<>(queueCapacity, accessFairness);

        CountDownLatch producingCountDownLatch = new CountDownLatch(numberOfProducers);
        CountDownLatch consumingcountDownLatch = new CountDownLatch(1);

        long start = System.nanoTime();

        Consumer consumer = new Consumer(drop, producingCountDownLatch, consumingcountDownLatch);

        (new Thread(consumer)).start();

        for (int i = 0; i < numberOfProducers; i++) {
            (new Thread(new Producer(i, numberOfMessages, drop, producingCountDownLatch))).start();
        }

        try {
            consumingcountDownLatch.await();
            long stop = System.nanoTime();
            System.out.printf(
                    "Messages recieved: %d\tExpected Messages: %d\tDiff: %d\tTime: %f\n",
                    consumer.getMessagesReceived(),
                    expectedMessagesConsumed,
                    Math.abs(consumer.getMessagesReceived() - expectedMessagesConsumed),
                    (stop - start) / 1000000000.0);
        } catch (InterruptedException ex) {
            System.err.println(ex);
        }
    }
}
