/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package ProjectEulerLib;

import java.util.List;

/**
 *
 * @author R.Impey
 */
public class PrimeGeneratorContext {

    private PrimeGeneratorStrategy primeGeneratorStrategy;

    public PrimeGeneratorContext(PrimeGeneratorStrategy primeGeneratorStrategy) {
        this.primeGeneratorStrategy = primeGeneratorStrategy;
    }
    
    public List<Integer> getPrimesUpTo(int max) {
        return this.primeGeneratorStrategy.getPrimesUpTo(max);
    }
}
