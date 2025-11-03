using Tyuiu.AntonovDI.Sprint4.Task0.V24.Lib;

namespace Tyuiu.AntonovDI.Sprint4.Task0.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultEvenArrEl()
        {
            DataService ds = new DataService();
            int[] array =  new int[] { 9, 5, 7, 4, 5, 3, 7, 8, 9, 1 };
            int res = ds.GetMultEvenArrEl(array);
            int wait = 32;
            Assert.AreEqual(wait, res);
        }
    }
}
