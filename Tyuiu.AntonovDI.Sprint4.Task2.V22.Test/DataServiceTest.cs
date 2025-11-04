using Tyuiu.AntonovDI.Sprint4.Task2.V22.Lib;
namespace Tyuiu.AntonovDI.Sprint4.Task2.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] array = new int[] { 6, 3, 3, 7, 7, 7, 7, 3, 3, 6, 4, 4, 8 };
            int res = ds.Calculate(array);
            int wait = 4608;
            Assert.AreEqual(wait, res);
        }
    }
}
