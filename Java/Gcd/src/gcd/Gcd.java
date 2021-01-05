/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package gcd;

/**
 *
 * @author Robert
 */
public class Gcd {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        int a;
        int b;
        
        if (args.length == 2) {
            a = Integer.parseInt(args[0]);
            b = Integer.parseInt(args[1]);
        } else {
            a = 42;
            b = 56;
        }
        
        GcdFinderContext gfc = new GcdFinderContext(new RecursiveEuclidGcdFinder());
        
        System.out.println(gfc.findGcd(a, b));
    }
}
