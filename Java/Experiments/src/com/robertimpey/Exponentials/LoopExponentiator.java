/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package com.robertimpey.Exponentials;

import java.math.BigDecimal;

/**
 * @author Robert
 */
public class LoopExponentiator extends Exponentiator {
    @Override
    protected BigDecimal calculateOtherValues(double base, int power) {
        BigDecimal result = new BigDecimal(base);

        while (power > 1) {
            result = result.multiply(new BigDecimal(base));
            power--;
        }

        return result;
    }
}
