using NUnit.Framework;

namespace BubbleSortApplication
{
    public class BubbleSortTests
    {
        private int[] testArray;
        private BubbleSort bubbleSort;

        [SetUp]
        public void SetUp()
        {
            testArray = new int[] { 1, 2, 3, 4, 6, 5, 7, 8, 9, 10 };
            bubbleSort = new BubbleSort(testArray);
        }

        [Test]
        public void TestAscendingOrder()
        {
            // Arrange
            int[] expectedResult = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Act
            int[] result = bubbleSort.Sort(SortDirection.Asc);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void TestDescendingOrder()
        {
            // Arrange
            int[] expectedResult = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            // Act
            int[] result = bubbleSort.Sort(SortDirection.Desc);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
