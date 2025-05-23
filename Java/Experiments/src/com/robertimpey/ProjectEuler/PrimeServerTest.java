/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package com.robertimpey.ProjectEuler;

import org.junit.*;

import java.util.LinkedList;
import java.util.List;

import static org.junit.Assert.assertEquals;

/**
 * @author R.Impey
 */
public class PrimeServerTest {

    private List<PrimeGeneratorContext> primeGeneratorContexts;

    public PrimeServerTest() {
    }

    @BeforeClass
    public static void setUpClass() {
    }

    @AfterClass
    public static void tearDownClass() {
    }

    @Before
    public void setUp() {
        primeGeneratorContexts = new LinkedList<>();

        primeGeneratorContexts.add(new PrimeGeneratorContext(new EratosthenesBAPrimeGeneratorStrategy()));
    }

    @After
    public void tearDown() {
        primeGeneratorContexts = null;
    }

    // Tests for getting a sorted list of primes.
    @Test
    public void testGetPrimesUpTo100() {
        for (PrimeGeneratorContext primeGeneratorContext : primeGeneratorContexts) {
            int[] expectedPrimesArray = {2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97};
            List<Integer> expectedPrimes = new LinkedList<>();
            for (int prime : expectedPrimesArray) {
                expectedPrimes.add(prime);
            }

            List<Integer> generatedPrimes = primeGeneratorContext.getPrimesUpTo(100);

            assertEquals(expectedPrimes, generatedPrimes);
        }
    }

    @Test(expected = IllegalArgumentException.class)
    public void testGettingPrimesUpToANegativeNumber() {
        for (PrimeGeneratorContext primeGeneratorContext : primeGeneratorContexts) {
            List<Integer> primes = primeGeneratorContext.getPrimesUpTo(-1);
        }
    }

    @Test
    public void testGetPrimesUpTo2() {
        for (PrimeGeneratorContext primeGeneratorContext : primeGeneratorContexts) {
            int[] expectedPrimesArray = {2};
            List<Integer> expectedPrimes = new LinkedList<>();
            for (int prime : expectedPrimesArray) {
                expectedPrimes.add(prime);
            }

            List<Integer> generatedPrimes = primeGeneratorContext.getPrimesUpTo(2);

            assertEquals(expectedPrimes, generatedPrimes);
        }
    }
}
