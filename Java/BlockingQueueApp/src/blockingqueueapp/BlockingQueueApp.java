/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package blockingqueueapp;

import java.util.concurrent.ArrayBlockingQueue;
import java.util.concurrent.BlockingQueue;
import java.util.concurrent.CountDownLatch;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author Robert
 */
public class BlockingQueueApp {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        int numberOfProducers = 50;
        int numberOfMessages = 500;

        int expectedMessagesConsumed = numberOfProducers * numberOfMessages;

        int queueCapacity;
        queueCapacity = 1;
        //queueCapacity = 10;
        //queueCapacity = numberOfProducers * numberOfMessages;
        boolean accessFairness = true;

        BlockingQueue<String> drop;
        drop = new ArrayBlockingQueue<>(queueCapacity, accessFairness);

        CountDownLatch countDownLatch = new CountDownLatch(numberOfProducers + 1);

        long start = System.nanoTime();
        for (int i = 0; i < numberOfProducers; i++) {
            (new Thread(new Producer(i, numberOfMessages, drop, countDownLatch))).start();
        }

        Consumer consumer = new Consumer(drop, countDownLatch);

        (new Thread(consumer)).start();

        try {
            countDownLatch.await();
            long stop = System.nanoTime();
            System.out.printf(
                    "Messages recieved: %d\tExpected Messages: %d\tDiff: %d\tTime: %f\n",
                    consumer.getMessagesReceived(),
                    expectedMessagesConsumed,
                    Math.abs(consumer.getMessagesReceived() - expectedMessagesConsumed),
                    (stop - start) / 1000000000.0);
        } catch (InterruptedException ex) {
            Logger.getLogger(BlockingQueueApp.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
}
