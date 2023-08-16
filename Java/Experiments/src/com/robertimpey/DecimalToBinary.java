package com.robertimpey;

/**
 * @author Robert Impey
 */
public class DecimalToBinary {
    public static void main(String[] args) {
        System.out.println("Simple Approach");
        for (int i = 0; i <= 7; i++) {
            System.out.printf("%d\t%s\n", i, decimalToBinary(i));
        }
        
        System.out.println("Recursive Approach");
        int bits = 8;
        for (int i = 0; i <= Math.pow(2, bits) - 1; i++) {
            System.out.printf("%d\t%s\n", i, decimalToBinaryRecursive(i));
        }
    }

    private static String decimalToBinary(int input) {
        if (input < 0 || input > 7) {
            throw new IllegalArgumentException();
        }

        StringBuilder result = new StringBuilder();

        if (input >= 4) {
            result.append('1');
            if (input >= 6) {
                result.append('1');
                if (input == 7) {
                    result.append('1');
                } else {
                    result.append('0');
                }
            } else {
                result.append('0');
                if (input == 5) {
                    result.append('1');
                } else {
                    result.append('0');
                }
            }
        } else {
            result.append('0');
            if (input >= 2) {
                result.append('1');
                if (input == 3) {
                    result.append('1');
                } else {
                    result.append('0');
                }
            } else {
                result.append('0');
                if (input == 1) {
                    result.append('1');
                } else {
                    result.append('0');
                }
            }
        }

        return result.toString();
    }

    private static String decimalToBinaryRecursive(int input) {
        if (input < 0) {
            throw new IllegalArgumentException();
        }

        if (input == 0) {
            return "0";
        }

        if (input == 1) {
            return "1";
        }

        // Find how many bits we need.
        int bits = (int)(Math.log(input) / Math.log(2)) + 1;

        // Find the greatest number that can be represented with this many bits.
        int max = (int)Math.pow(2, bits);

        // We want to know how much to change this value by to search from the mid point.
        int delta = max / -2;

        StringBuilder result = new StringBuilder();

        return decimalToBinaryRecursiveHelper(input, max, delta, result);
    }

    private static String decimalToBinaryRecursiveHelper(int input, int previousMidpoint, int delta, StringBuilder result) {
        if (delta == 0) {
            return result.toString();
        }

        int midpoint = previousMidpoint + delta;

        if (input >= midpoint) {
            result.append('1');
            return decimalToBinaryRecursiveHelper(input, midpoint, Math.abs(delta) / 2, result);
        } else {
            result.append('0');
            return decimalToBinaryRecursiveHelper(input, midpoint, Math.abs(delta) / -2, result);
        }
    }
}
