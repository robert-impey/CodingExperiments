package com.robertimpey;

public class SumIf357 {
    public static void main(String[] args)
    {
        int[] ns = new int[] { 0, 1, 3, 5, 7, 10, 50, 100 };

        for (int n : ns) {
            System.out.printf("n = %d, sum = %d, sum TR = %d, sum WL = %d\n",
                    n,
                    findSum(n),
                    findSumTr(n),
                    findSumWl(n));
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

        if (testN(n))
        {
            return findSumAcc(n - 1, acc + n);
        }

        return findSumAcc(n - 1, acc);
    }

    private static int findSumTr(int n)
    {
        return findSumAccTr(n, 0);
    }

    private static int findSumAccTr(int n, int acc)
    {
        if (n <= 0) {
            return acc;
        }

        if (testN(n))
        {
            acc += n;
        }

        return findSumAccTr(n - 1, acc);
    }

    private static int findSumWl(int n)
    {
        int sum = 0;
        while (n > 0) {
            if (testN(n)) {
                sum += n;
            }
            n--;
        }

        return sum;
    }

    private static boolean testN(int n)
    {
        return n % 3 == 0 || n % 5 == 0 || n % 7 == 0;
    }
}
