using Tyuiu.AntonovDI.Sprint4.Task5.V27.Lib;
namespace Tyuiu.AntonovDI.Sprint4.Task5.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[,] array = new int[5, 5] { { -5, 7, 7, 8, 5 },
                                           { 6, 5, 6, 8, 6 },
                                           { 7, 6, 8, 8, -5 },
                                           { 7, 6, 7, 8, 6 },
                                           { 7, 6, 7, -7, 5 } };
            int res = ds.Calculate(array);
            int wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}
