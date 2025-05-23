/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package com.robertimpey;

/**
 * @author Robert
 */
public class BinarySearch {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        final int max = 10;
        final int[] soughtNumbers = {-1, 0, 5, 9, 10};

        int[] as = new int[max];
        int i, j, k;

        for (i = 0; i < max; i++) {
            as[i] = i;
        }

        for (int soughtNumber : soughtNumbers) {
            System.out.printf("Seeking: %d\n", soughtNumber);

            // Simple Search
            System.out.print("Searching with a loop: ");
            i = 0;
            while (!((i == max - 1) || (as[i] == soughtNumber))) {
                i++;
            }

            if (as[i] == soughtNumber) {
                System.out.println("Found!");
            } else {
                System.out.println("Not found!");
            }

            // Binary Search
            System.out.print("Searching with binary search: ");
            i = 0;
            j = max - 1;
            do {
                k = (i + j) / 2;
                if (soughtNumber > as[k]) {
                    i = k + 1;
                } else {
                    j = k - 1;
                }
            } while (!((as[k] == soughtNumber) || (i >= j)));

            if (as[i] == soughtNumber) {
                System.out.println("Found!");
            } else {
                System.out.println("Not found!");
            }
        }
    }
}
