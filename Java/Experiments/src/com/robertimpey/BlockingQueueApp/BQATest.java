/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package com.robertimpey.BlockingQueueApp;

import org.junit.*;

import java.util.ArrayList;
import java.util.List;
import java.util.concurrent.ArrayBlockingQueue;
import java.util.concurrent.BlockingQueue;
import java.util.concurrent.CountDownLatch;
import java.util.logging.Level;
import java.util.logging.Logger;

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
        int numberOfProducers = 10;
        int numberOfMessages = 50;

        int expectedMessagesConsumed = numberOfProducers * numberOfMessages;

        int queueCapacity = 1;
        boolean accessFairness = true;

        BlockingQueue<String> drop = new ArrayBlockingQueue<>(queueCapacity, accessFairness);

        CountDownLatch producingCountDownLatch = new CountDownLatch(numberOfProducers);
        CountDownLatch consumingCountDownLatch = new CountDownLatch(1);

        List<Runnable> runnables = new ArrayList<>();

        Consumer consumer = new Consumer(drop, producingCountDownLatch, consumingCountDownLatch);
        runnables.add(consumer);

        for (int i = 0; i < numberOfProducers; i++) {
            runnables.add(new Producer(i, numberOfMessages, drop, producingCountDownLatch));
        }

        runRunnables(runnables);

        try {
            consumingCountDownLatch.await();
            assertEquals(expectedMessagesConsumed, consumer.getMessagesReceived());
        } catch (InterruptedException ex) {
            Logger.getLogger(BlockingQueueApp.class.getName()).log(Level.SEVERE, null, ex);
        }
    }

    /*
     * Helpers
     */
    private static void runRunnables(List<Runnable> runnables) {
        for (Runnable runnable : runnables) {
            (new Thread(runnable)).start();
        }
    }
}