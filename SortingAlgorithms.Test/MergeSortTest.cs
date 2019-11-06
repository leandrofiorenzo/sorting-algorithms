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
        public void PruebaQueElAlgoritmoOrdenaCorrectamenteSiEsUnArrayImpar()
        {
            MergeSort mergeSort = new MergeSort();
            int[] array = {3,5,2};
            int[] arrayOrdenado = {2,3,5};

            mergeSort.MergeSort2(array);

            Assert.AreEqual(array, arrayOrdenado);
        }

        [Test]
        public void PruebaQueElAlgoritmoOrdenaCorrectamenteSiEsUnArrayPar()
        {
            MergeSort mergeSort = new MergeSort();
            int[] array = {3,5,2,8};
            int[] arrayOrdenado = {2,3,5,8};

            mergeSort.MergeSort2(array);

            Assert.AreEqual(array, arrayOrdenado);
        }
    }
}