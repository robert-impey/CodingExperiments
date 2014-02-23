/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package stringdecoratordemo;

/**
 *
 * @author robert
 */
public class SimpleDecoratedString implements DecoratedString
{
    private final String theString;
    
    public SimpleDecoratedString(String theString)
    {
        this.theString = theString;
    }
    
    @Override
    public String getString() 
    {
        return this.theString;
    }
}
