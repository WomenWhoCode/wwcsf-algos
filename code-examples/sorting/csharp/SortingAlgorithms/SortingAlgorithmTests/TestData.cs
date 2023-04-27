using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithmTests
{
    public static class TestData
    {
        public static object[] Data
        {
            get => new[]
            {
                new object[] { new int[] { 6, 5, 3, 5, 8, 7, 5, 4 }, new int[] { 3, 4, 5, 5, 5, 6, 7, 8} },
                new object[] { new int[] { 6, 5, 3, 1, 8, 7, 2, 4 }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8} },
                new object[] { new int[] { 3, 7, 8, 5, 2, 1, 9, 5, 4 }, new int[] { 1, 2, 3, 4, 5, 5, 7, 8, 9 } },
                new object[] { new int[] { 3, 4, 2, 1, 7, 5, 8, 9, 0, 6 }, new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 } },
                new object[] { new int[] { 7, 6, 4, 3, 2, 1 }, new int[] { 1, 2, 3, 4, 6, 7 } },
                new object[] { new int[] { 1, 2, 3, 4, 6, 7 }, new int[] { 1, 2, 3, 4, 6, 7 } },
                new object[] { new int[] { 4, 2, 6, 3, 7, 1 }, new int[] { 1, 2, 3, 4, 6, 7 } },
                new object[] { new int[] { 4, 4, 6, 6, 7, 1 }, new int[] { 1, 4, 4, 6, 6, 7 } },
                new object[] { new int[] { }, new int[] { } }
            };
        }
    }
}
