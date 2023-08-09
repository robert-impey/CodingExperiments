/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package exponentials;

import java.math.BigDecimal;

/**
 *
 * @author Robert
 */
public class SquaringExponentiator extends Exponentiator
{
    @Override
    protected BigDecimal calculateOtherValues(double base, int power) 
    {
        if (power % 2 == 0) {
            BigDecimal tmp = calculate(base, power / 2);
            return tmp.multiply(tmp);
        }
        
        BigDecimal tmp = calculate(base, (power - 1) / 2);
        return new BigDecimal(base).multiply(tmp).multiply(tmp);
    }
}
