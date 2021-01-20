using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithm
{
    public class MergeSort : ISort
    {
        public int[] DoSort(int[] inputs)
        {
            if (inputs == null)
            {
                throw new ArgumentNullException("inputs");
            }

            if (inputs.Length <= 1)
            {
                return inputs;
            }

            int length = inputs.Length;

            int[] temps = new int[length];
            CopyArray(inputs, temps);

            TopDownSplitMerge(inputs, temps, 0, length - 1);

            return inputs;
        }

        private void TopDownSplitMerge(int[] inputs, int[] temps, int startIndex, int endIndex)
        {
            if (endIndex - startIndex <= 0)
            {
                return;
            }

            int middleIndex = (endIndex + startIndex) / 2;
            TopDownSplitMerge(temps, inputs, startIndex, middleIndex);
            TopDownSplitMerge(temps, inputs, middleIndex + 1, endIndex);

            TopDownMerge(temps, inputs, startIndex, middleIndex + 1, endIndex);
        }

        private void TopDownMerge(int[] inputs, int[] temps, int startIndex, int middleIndex, int endIndex)
        {
            int s = startIndex;
            int m = middleIndex;

            for (int k = startIndex; k <= endIndex; k++)
            {
                if (s < middleIndex && (m > endIndex || inputs[s] <= inputs[m]))
                {
                    temps[k] = inputs[s];
                    s++;
                }
                else
                {
                    temps[k] = inputs[m];
                    m++;
                }
            }
        }

        private void CopyArray(int[] inputs, int[] temps)
        {
            for (int i = 0; i < inputs.Length; i++)
            {
                temps[i] = inputs[i];
            }
        }
    }
}
