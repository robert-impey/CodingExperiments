/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package com.robertimpey.BlockingQueueApp;

import java.util.concurrent.BlockingQueue;
import java.util.concurrent.CountDownLatch;

/**
 * @author Robert
 */
public class Consumer implements Runnable {

    private final BlockingQueue<String> drop;
    private final CountDownLatch producingCountDownLatch, consumingCountDownLatch;
    private int messagesReceived = 0;

    public Consumer(
            BlockingQueue<String> drop,
            CountDownLatch producingCountDownLatch,
            CountDownLatch consumingCountDownLatch) {
        this.drop = drop;
        this.producingCountDownLatch = producingCountDownLatch;
        this.consumingCountDownLatch = consumingCountDownLatch;
    }

    @Override
    public void run() {
        try {
            String msg;
            while (producingCountDownLatch.getCount() > 0 || !drop.isEmpty()) {
                msg = drop.take();
                messagesReceived++;
            }
            consumingCountDownLatch.countDown();
        } catch (InterruptedException intEx) {
            System.err.println(intEx);
        }
    }

    public int getMessagesReceived() {
        return messagesReceived;
    }
}
