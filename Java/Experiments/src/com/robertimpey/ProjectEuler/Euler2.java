/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package com.robertimpey.ProjectEuler;

import java.util.LinkedList;
import java.util.List;

/**
 * @author rimpey
 */
public class Euler2 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // Create the list of Fibonacci numbers that do not exceed four million.
        List<Integer> fibonacciNumbers = new LinkedList<>();

        int previousFibonacciNumber = 1;
        int currentFibonacciNumber = 1;
        int max = 4 * (int) Math.pow(10, 6);
        fibonacciNumbers.add(previousFibonacciNumber);
        fibonacciNumbers.add(currentFibonacciNumber);

        while (currentFibonacciNumber <= max) {
            int temp = currentFibonacciNumber;
            currentFibonacciNumber += previousFibonacciNumber;
            previousFibonacciNumber = temp;

            fibonacciNumbers.add(currentFibonacciNumber);
        }

        // Find the sum of the even numbered terms.
        int sum = 0;
        for (Integer fibonacciNumber : fibonacciNumbers) {
            if (fibonacciNumber % 2 == 0) {
                sum += fibonacciNumber;
            }
        }

        System.out.println(sum);
    }
}
