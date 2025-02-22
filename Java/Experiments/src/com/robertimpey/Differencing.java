package com.robertimpey;

public class Differencing {
    public static void main(String[] args) {
        double[] data = new double[]{1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

        for (int i = 1; i < data.length; i++) {
            printDifference(data, i);
        }
    }

    private static void printDifference(double[] data, int i) {
        System.out.printf("%f - %f = %f\n", data[i], data[i - 1], data[i] - data[i - 1]);
    }
}
