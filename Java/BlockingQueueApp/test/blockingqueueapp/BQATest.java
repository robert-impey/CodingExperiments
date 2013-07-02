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
import org.junit.After;
import org.junit.AfterClass;
import org.junit.Before;
import org.junit.BeforeClass;
import org.junit.Test;
import static org.junit.Assert.*;

/**
 *
 * @author Robert
 */
public class BQATest {

    public BQATest() {
    }

    @BeforeClass
    public static void setUpClass() {
    }

    @AfterClass
    public static void tearDownClass() {
    }

    @Before
    public void setUp() {
    }

    @After
    public void tearDown() {
    }

    @Test
    public void producersAndConsumer() {
        int numberOfProducers = 100;
        int numberOfMessages = 500;
        
        int expectedMessagesConsumed = numberOfProducers * numberOfMessages;
        
        int queueCapacity = 1;
        boolean accessFairness = true;

        BlockingQueue<String> drop = new ArrayBlockingQueue<>(queueCapacity, accessFairness);

        CountDownLatch producingCountDownLatch = new CountDownLatch(numberOfProducers);
        CountDownLatch consumingcountDownLatch = new CountDownLatch(1);

        Consumer consumer = new Consumer(drop, producingCountDownLatch, consumingcountDownLatch);

        (new Thread(consumer)).start();

        for (int i = 0; i < numberOfProducers; i++) {
            (new Thread(new Producer(i, numberOfMessages, drop, producingCountDownLatch))).start();
        }
        
        try {
            consumingcountDownLatch.await();
            assertEquals(expectedMessagesConsumed, consumer.getMessagesReceived());
        } catch (InterruptedException ex) {
            Logger.getLogger(BlockingQueueApp.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
}