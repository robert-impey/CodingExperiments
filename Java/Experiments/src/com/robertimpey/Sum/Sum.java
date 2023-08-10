/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package com.robertimpey.Sum;

/**
 *
 * @author Robert
 */
public class Sum {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        int max;
        
        if (args.length == 1) {
            max = Integer.parseInt(args[0]);
        } else {
            max = 10;
        }
                
        System.out.printf("Max: %d\tLoops: %d\tMultiplication: %d\n", max, loops(max), multiplication(max));
    }
    
    static int loops(int max)
    {
        int sum = 0;
        
        for (int i = 0; i <= max; i++)
        {
            sum += i;
        }
        
        return sum;
    }
    
    static int multiplication(int max)
    {
        return ((1 + max) * max) / 2;
    }
}
