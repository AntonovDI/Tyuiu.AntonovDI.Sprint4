using Tyuiu.AntonovDI.Sprint4.Task6.V4.Lib;

namespace Tyuiu.AntonovDI.Sprint4.Task6.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string[] mas = { "Москва", "Санкт Петербург", "Новосибирск", "Екатеринбург", "Нижний Новгород", "Казахстан", "Самара" };
            string[] res = ds.Calculate(mas);
            string[] wait = { "Москва", "Самара" };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
