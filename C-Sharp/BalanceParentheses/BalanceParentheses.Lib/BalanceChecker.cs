﻿namespace BalanceParentheses.Lib
{
    public class BalanceChecker
    {
        public static bool IsStringBalanced(string beingChecked)
        {
            var unbalancedParenthesesCount = 0;

            foreach (var c in beingChecked)
            {
                if (c == '(')
                    unbalancedParenthesesCount++;

                if (c == ')')
                    unbalancedParenthesesCount--;

                if (unbalancedParenthesesCount < 0)
                    return false;
            }

            return unbalancedParenthesesCount == 0;
        }
    }
}
