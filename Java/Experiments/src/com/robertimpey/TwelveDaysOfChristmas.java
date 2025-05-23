/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package com.robertimpey;

/**
 * @author Robert
 */
public class TwelveDaysOfChristmas {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        int totalNumberOfItems = 0;

        for (int dayOfChristmas = 1; dayOfChristmas <= 12; dayOfChristmas++) {
            for (int numberOfItems = 1; numberOfItems <= dayOfChristmas; numberOfItems++) {
                totalNumberOfItems += numberOfItems;
            }
        }

        System.out.println("The total number of items: " + totalNumberOfItems);
    }
}
