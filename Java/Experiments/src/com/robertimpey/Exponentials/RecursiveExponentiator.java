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
public class RecursiveExponentiator extends Exponentiator
{
    @Override
    protected BigDecimal calculateOtherValues(double base, int power) 
    {
        return new BigDecimal(base).multiply(this.calculate(base, power - 1));
    }
}
