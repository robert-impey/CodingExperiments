package com.robertimpey.diff2sums;

public class Solution {
    public int differenceOfSums(int n, int m) {
        var num1 = 0;
        var num2 = 0;

        for (int i = 1; i <= n; i++) {
            if (i % m == 0) {
                num2 += i;
            } else {
                num1 += i;
            }
        }

        return num1 - num2;
    }
}
