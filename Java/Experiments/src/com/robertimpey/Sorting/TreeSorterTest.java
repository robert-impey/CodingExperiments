/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.robertimpey.Sorting;

import com.robertimpey.Sorting.TreeSort.TreeSorter;
import org.junit.*;

import static junit.framework.TestCase.assertEquals;

/**
 *
 * @author Robert
 */
public class TreeSorterTest {
    
    public TreeSorterTest() {
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
    public void emptyTreeSort() {
        int[] unsorted = new int[0];

        TreeSorter treeSorter = new TreeSorter();
        int[] sorted = treeSorter.sort(unsorted);

        assertArrays(sorted, unsorted);
    }

    @Test
    public void singletonTreeSort() {
        int[] unsorted = { 1 };

        TreeSorter treeSorter = new TreeSorter();
        int[] sorted = treeSorter.sort(unsorted);

        assertArrays(sorted, unsorted);
    }

    @Test
    public void unsortedTreeSort() {
        int[] unsorted = {9, 3, 4, 7, 8, 2, 1, 6, 5};

        TreeSorter treeSorter = new TreeSorter();
        int[] sorted = treeSorter.sort(unsorted);

        assertArrays(sorted, unsorted);
    }

    @Test
    public void unsortedDupsTreeSort() {
        int[] unsorted = {9, 3, 4, 3, 7, 8, 2, 1, 1, 6, 9, 5};

        TreeSorter treeSorter = new TreeSorter();
        int[] sorted = treeSorter.sort(unsorted);

        assertArrays(sorted, unsorted);
    }

    private void assertArrays(int[] sorted, int[] unsorted) {
        assertEquals(true, areSorted(sorted));
        assertEquals(unsorted.length, sorted.length);
    }

    private boolean areSorted(int[] candidate) {
        if (candidate.length > 1) {
            for (int i = 1; i < candidate.length; i++) {
                if (candidate[i] < candidate[i - 1]) {
                    return false;
                }
            }
        }

        return true;
    }
}
