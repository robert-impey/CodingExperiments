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
public class Consumer implements Runnable {

    private final BlockingQueue<String> drop;
    private final CountDownLatch countDownLatch;
    private int messagesReceived = 0;

    public Consumer(BlockingQueue<String> drop, CountDownLatch countDownLatch) {
        this.drop = drop;
        this.countDownLatch = countDownLatch;
    }

    @Override
    public void run() {
        try {
            String msg;
            while (!drop.isEmpty()) {
                msg = drop.take();
                messagesReceived++;
                System.out.println(msg);
            }
            countDownLatch.countDown();
        } catch (InterruptedException intEx) {
            System.out.println(intEx);
        }
    }

    public int getMessagesReceived() {
        return messagesReceived;
    }
}
