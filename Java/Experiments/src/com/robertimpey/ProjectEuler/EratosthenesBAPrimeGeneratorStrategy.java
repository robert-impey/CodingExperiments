/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package com.robertimpey.ProjectEuler;

import java.util.LinkedList;
import java.util.List;

/**
 * EratosthenesBAPrimeGeneratorStrategy
 * <p>
 * Generating primes using a boolean array and the Sieve of Eratosthenes.
 *
 * @author R.Impey
 */
public class EratosthenesBAPrimeGeneratorStrategy implements PrimeGeneratorStrategy {

    @Override
    public List<Integer> getPrimesUpTo(int max) {
        if (max <= 0) {
            throw new IllegalArgumentException("max must be greater than 0!");
        }
        List<Integer> primes = new LinkedList<>();

        if (max > 0) {
            // Create the list of integers as a boolean array
            boolean[] candidatePrimes = new boolean[max + 1];

            for (int i = 2; i < candidatePrimes.length; i++) {
                candidatePrimes[i] = true;
            }

            // Sieve the integers
            candidatePrimes[0] = false;
            candidatePrimes[1] = false;

            int searchTo = (int) (Math.ceil(Math.sqrt(max)) + 1);
            for (int i = 2; i < searchTo; i++) {
                if (candidatePrimes[i]) {
                    int j = 2 * i;
                    while (j < candidatePrimes.length) {
                        candidatePrimes[j] = false;
                        j += i;
                    }
                }
            }

            // Convert the array of booleans to a list of integers.

            for (int i = 0; i < candidatePrimes.length; i++) {
                if (candidatePrimes[i]) {
                    primes.add(i);
                }
            }
        }

        return primes;
    }
}
