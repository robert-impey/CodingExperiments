/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package blockingqueueapp;

import java.util.concurrent.BlockingQueue;

/**
 *
 * @author Robert
 */
public class Consumer implements Runnable {

    private BlockingQueue<String> drop;

    public Consumer(BlockingQueue<String> d) {
        this.drop = d;
    }

    @Override
    public void run() {
        try {
            String msg = null;
            while (!((msg = drop.take()).equals("DONE"))) {
                System.out.println(msg);
            }
        } catch (InterruptedException intEx) {
            System.out.println("Interrupted! "
                    + "Last one out, turn out the lights!");
        }
    }
}
