/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package blockingqueueapp;

import java.util.concurrent.BlockingQueue;
import java.util.concurrent.CountDownLatch;

/**
 *
 * @author Robert
 */
public class Producer implements Runnable {

    private final int id;
    private final int numberOfMessages;
    private final BlockingQueue<String> drop;
    private final CountDownLatch countDownLatch;

    public Producer(int id, int numberOfMessages, BlockingQueue<String> drop, CountDownLatch countDownLatch) {
        this.id = id;
        this.numberOfMessages = numberOfMessages;
        this.drop = drop;
        this.countDownLatch = countDownLatch;
    }

    @Override
    public void run() {
        try {
            for (int i = 0; i < numberOfMessages; i++) {
                drop.put(id + " " + i);
            }
            countDownLatch.countDown();
        } catch (InterruptedException intEx) {
            System.out.println(intEx);
        }
    }
}
