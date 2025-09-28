using Tyuiu.MoskalevEA.Sprint1.Task1.V11.Lib;

namespace Tyuiu.MoskalevEA.Sprint1.Task1V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 12.0;
            double y = 5.0;
                var res = ds.Calculate(x, y);
            Assert.AreEqual(2, res);
        }
    }
}
