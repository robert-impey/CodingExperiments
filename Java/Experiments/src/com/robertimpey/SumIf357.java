package com.robertimpey;

public class SumIf357 {
    public static void main(String[] args)
    {
        int[] ns = new int[] { 0, 1, 3, 5, 7, 10, 50, 100 };

        for (int n : ns) {
            System.out.printf("n = %d, sum = %d\n", n, findSum(n));
        }
    }

    private static int findSum(int n)
    {
        return findSumAcc(n, 0);
    }

    private static int findSumAcc(int n, int acc)
    {
        if (n <= 0) {
            return acc;
        }

        if (n % 3 == 0 || n % 5 == 0 || n % 7 == 0)
        {
            return findSumAcc(n - 1, acc + n);
        }

        return findSumAcc(n - 1, acc);
    }
}
