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
        int queueCapacity = 1;
        boolean accessFairness = true;
        
        int numberOfProducers = 5;
        int numberOfMessages = 100;
        
        BlockingQueue<String> drop;
        drop = new ArrayBlockingQueue<>(queueCapacity, accessFairness);
        
        CountDownLatch countDownLatch = new CountDownLatch(numberOfProducers);
        
        for (int i = 0; i < numberOfProducers; i++) {
            (new Thread(new Producer(i, numberOfMessages, drop, countDownLatch))).start();
        }
        
        (new Thread(new Consumer(drop, countDownLatch))).start();
    }
}
