/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package com.robertimpey.Exponentials;

import java.math.BigDecimal;

/**
 *
 * @author Robert
 */
public abstract class Exponentiator 
{
    public BigDecimal calculate(double base, int power)
    {
        if (power == 0) {
            return BigDecimal.ONE;
        }
        
        if (power == 1) {
            return new BigDecimal(base);
        }
        
        if (power < 0) {
            return BigDecimal.ONE.divide(calculate(base, power * -1));
        }
        
        return calculateOtherValues(base, power);
    }
    
    protected abstract BigDecimal calculateOtherValues(double base, int power);
}
