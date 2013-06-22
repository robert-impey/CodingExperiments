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
public interface PrimeGeneratorStrategy {
    List<Integer> getPrimesUpTo(int max);
}
