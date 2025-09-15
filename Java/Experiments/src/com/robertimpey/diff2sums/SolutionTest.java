package com.robertimpey.diff2sums;

import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.Test;

public class SolutionTest {
    @Test
    void ex1() {
        var sln = new Solution();
        var diff = sln.differenceOfSums(10, 3);
        Assertions.assertEquals(19, diff);
    }

    @Test
    void ex2() {
        var sln = new Solution();
        var diff = sln.differenceOfSums(5, 6);
        Assertions.assertEquals(15, diff);
    }

    @Test
    void ex3() {
        var sln = new Solution();
        var diff = sln.differenceOfSums(5, 1);
        Assertions.assertEquals(-15, diff);
    }
}
