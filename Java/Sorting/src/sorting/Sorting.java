/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package sorting;

import sorting.TreeSort.TreeSorter;

/**
 *
 * @author Robert
 */
public class Sorting {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        int[] unsorted = { 9, 3, 4, 7, 8, 2, 1, 6, 5 };
        
        TreeSorter treeSorter = new TreeSorter();
        int[] sorted = treeSorter.sort(unsorted);
        
        for (int num : sorted) {
            System.out.print(num + " ");
        }
        System.out.println();
    }
}
