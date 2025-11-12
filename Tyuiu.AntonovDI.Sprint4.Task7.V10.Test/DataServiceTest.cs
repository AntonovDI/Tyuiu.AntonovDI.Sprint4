using System.Globalization;
using Tyuiu.AntonovDI.Sprint4.Task7.V10.Lib;

namespace Tyuiu.AntonovDI.Sprint4.Task7.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int m = 3;
            int n = 4;
            string value = "695847142536";
            int res = ds.Calculate(m, n, value);
            int wait = 30;
            Assert.AreEqual(wait, res);

        }
    }
}
