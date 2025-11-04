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
            int[] array = { 5, 2, 4, 4, 3, 6, 4, 3, 3, 4, 5, 3, 1 };
            int res = ds.Calculate(array);
            int wait = 2025;
            Assert.AreEqual(wait, res);
        }
    }
}
