using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithm
{
    public class SelectionSort : ISort
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

            for (int i = 0; i < inputs.Length; i++)
            {
                int minValueIndex = i;
                for (int j = i + 1; j < inputs.Length; j++)
                {
                    if (inputs[j] < inputs[minValueIndex])
                    {
                        minValueIndex = j;
                    }
                }
                if (minValueIndex != i)
                {
                    //swap
                    inputs.Swap(i, minValueIndex);
                }
            }

            return inputs;
        }
    }
}
