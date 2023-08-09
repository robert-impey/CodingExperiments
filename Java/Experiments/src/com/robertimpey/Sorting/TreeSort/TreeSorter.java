/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.robertimpey.Sorting.TreeSort;

/**
 *
 * @author Robert
 */
public class TreeSorter {

    public int[] sort(int[] unsorted) {
        if (unsorted.length < 2) {
            return unsorted;
        } else {
            Tree tree = new Tree(unsorted[0]);
            
            for (int i = 1; i < unsorted.length; i++) {
                tree.add(unsorted[i]);
            }
            
            int[] sorted = new int[unsorted.length];
            int i = 0;
            for (int num : tree.traverse()) {
                sorted[i++] = num;
            }
            
            return sorted;
        }
    }
}
