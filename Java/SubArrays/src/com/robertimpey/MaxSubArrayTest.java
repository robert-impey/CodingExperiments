package com.robertimpey;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.*;

class MaxSubArrayTest {
    @Test
    void sum()
    {
        MaxSubArray maxSubArray = new MaxSubArray();

        int[] nums = {-2,1,-3,4,-1,2,1,-5,4};

        int sum = maxSubArray.solve(nums);

        assertEquals(6, sum);
    }
}