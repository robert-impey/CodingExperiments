/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package com.robertimpey;

/**
 *
 * @author rimpey
 */
public class HelloWorld {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        System.out.println("Hello, world!");
        
        double fahr = 70.0;
        
        fahr = fahr - 32;
        
        fahr = fahr / 9;
        fahr = fahr * 5;
        
        System.out.println(fahr);
        
        String message = "Today's temperature is ";
        //float fahr = 212f;
        
        System.out.println(message + fahr);
    }
}
