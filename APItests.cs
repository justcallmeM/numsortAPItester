using numsortAPI.Services;
using Xunit;

namespace apiTester
{
    public class APItests
    {
        [Fact]
        public void SortNumbers_SortAnArrayOfNumbers()
        {
            //Arrange
            QuickSortService quickSortService = new QuickSortService();
            double[] expected = new double[] { 1, 1.5, 2.3, 5.5, 10 };
            double[] dataToSort = new double[] { 10, 1.5, 2.3, 1, 5.5 };

            //Act
            double[] actual = quickSortService.SortMyArray(dataToSort);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
