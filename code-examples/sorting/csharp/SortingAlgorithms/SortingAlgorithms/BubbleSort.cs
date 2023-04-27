using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithm
{
    public class BubbleSort : ISort
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
                bool unSorted = false;

                for (int j = 1; j < inputs.Length - i; j++) 
                {
                    if (inputs[j] < inputs[j - 1])
                    {
                        inputs.Swap(j, j - 1);
                        unSorted = true;
                    }
                }
                if (!unSorted)
                {
                    break;
                }
            }

            return inputs;
        }
    }
}
