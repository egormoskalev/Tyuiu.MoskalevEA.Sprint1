using Tyuiu.MoskalevEA.Sprint1.Task2.V3.Lib;

namespace Tyuiu.MoskalevEA.Sprint1.Task2.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 10;
            var res = ds.ConvertHourToMin(x);
            Assert.AreEqual(600, res);
        }
    }
}
