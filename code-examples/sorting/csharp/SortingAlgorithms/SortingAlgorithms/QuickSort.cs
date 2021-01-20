using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithm
{
    public class QuickSort : ISort
    {
        public QuickSort(bool isRightMostPivot)
        {
            IsRightMostPivot = isRightMostPivot;
        }

        public bool IsRightMostPivot { get; }

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


            DoQuickSort(inputs, 0, length - 1);

            return inputs;
        }

        private void DoQuickSort(int[] inputs, int startIndex, int endIndex)
        {
            if (startIndex >= endIndex)
            {
                return;
            }

            int pivotIndex;
            if (!IsRightMostPivot)
            {
                pivotIndex = DoPartitionWithMiddlePivot(inputs, startIndex, endIndex);
            }
            else
            {
                pivotIndex = DoPartitionWithRightMostPivot(inputs, startIndex, endIndex);
            }

            DoQuickSort(inputs, startIndex, pivotIndex - 1);
            DoQuickSort(inputs, pivotIndex + 1, endIndex);
        }

        private int DoPartitionWithMiddlePivot(int[] inputs, int startIndex, int endIndex)
        {
            int pivotIndex = (startIndex + endIndex) / 2;
            int pivot = inputs[pivotIndex];
            int lo = startIndex;
            int hi = endIndex;

            inputs.Swap(pivotIndex, endIndex);
            while (lo < hi)
            {
                while (inputs[lo] < pivot && lo < endIndex)
                {
                    lo++;
                }

                while (inputs[hi] >= pivot && hi > startIndex)
                {
                    hi--;
                }

                if (lo < hi)
                {
                    inputs.Swap(lo, hi);
                }                
            }

            inputs.Swap(lo, endIndex);
            return lo;
        }

        private int DoPartitionWithRightMostPivot(int[] inputs, int startIndex, int endIndex)
        {
            int pivot = inputs[endIndex];
            int i = startIndex;
            int pivotIndex = endIndex;
            while (i < pivotIndex)
            {
                if (inputs[i] > pivot)
                {
                    inputs.Swap(i, pivotIndex - 1);
                    inputs.Swap(pivotIndex, pivotIndex - 1);
                    pivotIndex--;
                }
                else
                {
                    i++;
                }
            }

            return pivotIndex;
        }
    }
}
