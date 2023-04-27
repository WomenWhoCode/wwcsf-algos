using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithm
{
    public static class ArrayExtension
    {
        public static void Swap(this int[] inputs, int i, int j)
        {
            int temp = inputs[i];
            inputs[i] = inputs[j];
            inputs[j] = temp;
        }
    }
}
