/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package com.robertimpey.Gcd;

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

        if (args.length != 2) {
            System.err.println("Please give me two different counting numbers!");
            return;
        }

        a = Integer.parseInt(args[0]);
        b = Integer.parseInt(args[1]);

        GcdFinderContext gfc = new GcdFinderContext(new RecursiveEuclidGcdFinder());

        int gcd = gfc.findGcd(a, b);
        
        System.out.printf("gcd(%d, %d) = %d\n", a, b, gcd);
        
        int product = a * b;
        int absProduct;        
        if (product < 0) {
            absProduct = -1 * product;
        } else {
            absProduct =  product;
        }
        
        int lcm = absProduct / gcd;
        
        System.out.printf("lcm(%d, %d) = %d\n", a, b, lcm);
    }
}
