/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package com.robertimpey.Gcd;

/**
 * @author Robert
 */
public class GcdFinderContext {
    private final GcdFinder gcdFinder;

    public GcdFinderContext(GcdFinder gcdFinder) {
        this.gcdFinder = gcdFinder;
    }

    public int findGcd(int a, int b) {
        if (a < 1 || b < 1) {
            throw new IllegalArgumentException();
        }

        return this.gcdFinder.findGcd(a, b);
    }
}
