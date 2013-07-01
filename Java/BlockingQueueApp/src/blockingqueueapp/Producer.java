/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package blockingqueueapp;

import java.util.Arrays;
import java.util.List;
import java.util.concurrent.BlockingQueue;

/**
 *
 * @author Robert
 */
public class Producer implements Runnable {

    private BlockingQueue<String> drop;
    List<String> messages = Arrays.asList(
            "Mares eat oats",
            "Does eat oats",
            "Little lambs eat ivy",
            "Wouldn't you eat ivy too?");

    public Producer(BlockingQueue<String> d) {
        this.drop = d;
    }

    @Override
    public void run() {
        try {
            for (String s : messages) {
                drop.put(s);
            }
            drop.put("DONE");
        } catch (InterruptedException intEx) {
            System.out.println(intEx);
        }
    }
}
