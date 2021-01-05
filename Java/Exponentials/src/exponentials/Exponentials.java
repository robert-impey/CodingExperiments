/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package exponentials;

/**
 *
 * @author Robert
 */
public class Exponentials
{

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) 
    {
        double base; 
        int power;
        
        if (args.length == 2) {
            base = Double.parseDouble(args[0]);
            power = Integer.parseInt(args[1]);
        } else {
            base = 2.0;
            power = 8;
        }
        
        Exponentiator loops = new LoopExponentiator();
        Exponentiator squaring = new SquaringExponentiator();
        Exponentiator recursive = new RecursiveExponentiator();
        
        System.out.printf(
            "%f ^ %d = %f = %f = %f\n", 
            base, power, 
            loops.calculate(base, power), 
            squaring.calculate(base, power),
            recursive.calculate(base, power)
        );
    }
}
