using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortingAlgorithm;

namespace SortingAlgorithmTests
{
    [TestClass]
    public class HeapSortTests
    {

        [TestMethod]
        [DynamicData(nameof(TestData.Data), typeof(TestData), DynamicDataSourceType.Property)]
        public void TestSort(int[] inputs, int[] expectedOutputs)
        {
            //given

            //when
            ISort sort = new HeapSort();
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
