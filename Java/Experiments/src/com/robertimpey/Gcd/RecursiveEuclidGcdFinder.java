/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package com.robertimpey.Gcd;

/**
 * @author Robert
 */
public class RecursiveEuclidGcdFinder implements GcdFinder {
    @Override
    public int findGcd(int a, int b) {
        int larger, smaller;

        if (a > b) {
            larger = a;
            smaller = b;
        } else {
            larger = b;
            smaller = a;
        }

        if (smaller == 0) {
            return larger;
        } else {
            return findGcd(larger - smaller, smaller);
        }
    }
}
