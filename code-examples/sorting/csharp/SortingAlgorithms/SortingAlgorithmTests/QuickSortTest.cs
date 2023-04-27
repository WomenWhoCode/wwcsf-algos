using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortingAlgorithm;

namespace SortingAlgorithmTests
{
    [TestClass]
    public class QuickSortTests
    {

        [TestMethod]
        [DynamicData(nameof(TestData.Data), typeof(TestData), DynamicDataSourceType.Property)]
        public void TestSortAsRightMostElement(int[] inputs, int[] expectedOutputs)
        {
            //given
            bool isRightMostPivot = true;

            //when
            ISort sort = new QuickSort(isRightMostPivot);
            int[] actualOutputs = sort.DoSort(inputs);

            //then
            Assert.AreEqual(expectedOutputs.Length, actualOutputs.Length);
            for (int i = 0; i < inputs.Length - 1; i++)
            {
                Assert.AreEqual(expectedOutputs[i], actualOutputs[i]);
            }
        }

        [TestMethod]
        [DynamicData(nameof(TestData.Data), typeof(TestData), DynamicDataSourceType.Property)]
        public void TestSortPivotAsMiddleElement(int[] inputs, int[] expectedOutputs)
        {
            //given
            bool isRightMostPivot = false;

            //when
            ISort sort = new QuickSort(isRightMostPivot);
            int[] actualOutputs = sort.DoSort(inputs);

            //then
            Assert.AreEqual(expectedOutputs.Length, actualOutputs.Length);
            for (int i = 0; i < inputs.Length - 1; i++)
            {
                Assert.AreEqual(expectedOutputs[i], actualOutputs[i]);
            }
        }
    }
}
