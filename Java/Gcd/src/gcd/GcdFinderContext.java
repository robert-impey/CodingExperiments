/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package gcd;

/**
 *
 * @author Robert
 */
public class GcdFinderContext {
    private GcdFinder gcdFinder;
    
    public GcdFinderContext(GcdFinder gcdFinder)
    {
        this.gcdFinder = gcdFinder;
    }
    
    public int findGcd(int a, int b)
    {
        if (a < 1 || b < 1) {
            throw new IllegalArgumentException();
        }
        
        return this.gcdFinder.findGcd(a, b);
    }
}
