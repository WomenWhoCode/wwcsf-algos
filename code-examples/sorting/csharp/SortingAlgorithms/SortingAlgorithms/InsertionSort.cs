using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithm
{
    public class InsertionSort : ISort
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

            for (int i = 1; i < inputs.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (inputs[j] < inputs[j - 1])
                    {
                        inputs.Swap(j, j - 1);
                        continue;
                    }
                    break;                    
                }
            }

            return inputs;
        }
    }
}
