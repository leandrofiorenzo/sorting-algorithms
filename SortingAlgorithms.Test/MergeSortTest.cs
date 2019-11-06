using NUnit.Framework;
using SortingAlgorithms.Library;

namespace SortingAlgorithms.Test
{
    public class MergeSortTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void PruebaQueElAlgoritmoOrdenaCorrectamente()
        {
            MergeSort mergeSort = new MergeSort();

            Assert.AreEqual(1,2);
        }
    }
}