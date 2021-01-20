using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithm
{
    public class HeapSort : ISort
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

            Heapify(inputs);

            for (int i = 1; i < inputs.Length; i++)
            {
                inputs.Swap(0, length - i);
                SiftDown(inputs, length - i, 0);
            }

            return inputs;
        }

        private void Heapify(int[] inputs)
        {
            int length = inputs.Length;

            for (int i = length / 2 - 1; i >= 0; i--)
                SiftDown(inputs, length, i);
        }

        private void SiftDown(int[] inputs, int heapSize, int startNode)
        {
            int largestIndex = startNode;
            int leftChild = LeftChild(startNode);
            int rightChild = RightChild(startNode);

            if (leftChild < heapSize && inputs[leftChild] > inputs[largestIndex])
            {
                largestIndex = leftChild;
            }

            if (rightChild < heapSize && inputs[rightChild] > inputs[largestIndex])
            {
                largestIndex = rightChild;
            }

            if (largestIndex != startNode)
            {
                inputs.Swap(largestIndex, startNode);
                SiftDown(inputs, heapSize, largestIndex);
            }
        }

        private int LeftChild(int parentIndex)
        {
            return parentIndex * 2 + 1;
        }

        private int RightChild(int parentIndex)
        {
            return parentIndex * 2 + 2;
        }
    }
}
