/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package blockingqueueapp;

import java.util.concurrent.ArrayBlockingQueue;
import java.util.concurrent.BlockingQueue;

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
        
        BlockingQueue<String> drop;
        drop = new ArrayBlockingQueue(queueCapacity, accessFairness);
        
        for (int i = 0; i < numberOfProducers; i++) {
            (new Thread(new Producer(i, drop))).start();
        }
        
        (new Thread(new Consumer(drop))).start();
    }
}
