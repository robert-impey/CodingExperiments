/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package com.robertimpey.ProjectEuler;

import java.util.List;

/**
 * @author R.Impey
 */
public class PrimeGeneratorContext {

    private final PrimeGeneratorStrategy primeGeneratorStrategy;

    public PrimeGeneratorContext(PrimeGeneratorStrategy primeGeneratorStrategy) {
        this.primeGeneratorStrategy = primeGeneratorStrategy;
    }

    public List<Integer> getPrimesUpTo(int max) {
        return this.primeGeneratorStrategy.getPrimesUpTo(max);
    }
}
