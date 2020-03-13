﻿using Sorting.Lib.Algorithms;
using Xunit;

namespace Sorting.Test.Algorithms
{
    public class InsertionSorterTest
    {
        [Fact]
        public void ShouldSort()
        {
            AlgorithmChecker.TestSorter(new InsertionSorter());
        }
    }
}