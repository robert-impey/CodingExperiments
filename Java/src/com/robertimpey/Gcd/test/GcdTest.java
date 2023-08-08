/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

import java.util.ArrayList;
import java.util.List;
import java.util.Random;
import gcd.*;
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
public class GcdTest {
    private List<GcdFinderContext> gcdFinderContexts;
    private final int[] PRIMES = {2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97};
    
    public GcdTest() {
    }

    @BeforeClass
    public static void setUpClass() throws Exception {
    }

    @AfterClass
    public static void tearDownClass() throws Exception {
    }

    @Before
    public void setUp() {
        gcdFinderContexts = new ArrayList<GcdFinderContext>();
        
        gcdFinderContexts.add(new GcdFinderContext(new RecursiveEuclidGcdFinder()));
    }

    @After
    public void tearDown() {
    }
    
    @Test(expected=IllegalArgumentException.class)
    public void whenTheFirstArgumentIsLessThan1AnExceptionIsThrown() {
        for (GcdFinderContext gcdFinderContext : gcdFinderContexts) {
            gcdFinderContext.findGcd(0, 1);
        }
    }
    
    @Test(expected=IllegalArgumentException.class)
    public void whenTheSecondArgumentIsLessThan1AnExceptionIsThrown() {
        for (GcdFinderContext gcdFinderContext : gcdFinderContexts) {
            gcdFinderContext.findGcd(1, 0);
        }
    }
    
    @Test
    public void whenTwoNumbersAreGivenTheCorrectGcdIsFound()
    {
        List<Integer> expecteds = new ArrayList<Integer>();
        List<Integer> results = new ArrayList<Integer>();
        
        for (GcdFinderContext gcdFinderContext : gcdFinderContexts) {
            expecteds.add(21);
            results.add(gcdFinderContext.findGcd(252, 105));
        }
        
        assertEquals(expecteds, results);
    }
    
    @Test
    public void whenTwoRandomNumbersAreGivenTheCorrectGcdIsFound()
    {
        Random random = new Random();
        int RUNS = 10;
        
        int[][] gcds = new int[RUNS][gcdFinderContexts.size()];
        int[][] results = new int[RUNS][gcdFinderContexts.size()];
        for (int i = 0; i < RUNS; i++) {
            for (int j = 0; j < gcdFinderContexts.size(); j++) {
                int gcdIndex = random.nextInt(PRIMES.length);

                int firstMultiplierIndex;
                do {
                    firstMultiplierIndex = random.nextInt(PRIMES.length);
                } while (gcdIndex == firstMultiplierIndex);
                int secondMultiplierIndex;
                do {
                    secondMultiplierIndex = random.nextInt(PRIMES.length);
                } while (gcdIndex == firstMultiplierIndex || secondMultiplierIndex == firstMultiplierIndex);

                gcds[i][j] = PRIMES[gcdIndex];
                results[i][j]
                    = gcdFinderContexts.get(j).findGcd(
                        PRIMES[gcdIndex] * PRIMES[firstMultiplierIndex], 
                        PRIMES[gcdIndex] * PRIMES[secondMultiplierIndex]
                    );
            }
        }
        
        assertArrayEquals(gcds, results);
    }
}
