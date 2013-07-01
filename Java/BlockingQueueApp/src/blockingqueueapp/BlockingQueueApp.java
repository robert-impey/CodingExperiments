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
        BlockingQueue<String> drop = new ArrayBlockingQueue(1, true);
        (new Thread(new Producer(drop))).start();
        (new Thread(new Consumer(drop))).start();
    }
}
