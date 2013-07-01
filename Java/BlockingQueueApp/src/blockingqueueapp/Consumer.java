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

    private BlockingQueue<String> drop;
    private final CountDownLatch countDownLatch;

    public Consumer(BlockingQueue<String> drop, CountDownLatch countDownLatch) {
        this.drop = drop;
        this.countDownLatch = countDownLatch;
    }

    @Override
    public void run() {
        try {
            String msg;
            while (countDownLatch.getCount() > 0) {
                msg = drop.take();
                System.out.println(msg);
            }
        } catch (InterruptedException intEx) {
            System.out.println(intEx);
        }
    }
}
