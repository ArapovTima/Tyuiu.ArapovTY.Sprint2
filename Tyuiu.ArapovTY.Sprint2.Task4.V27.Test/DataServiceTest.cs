using Tyuiu.ArapovTY.Sprint2.Task4.V27.Lib;
namespace Tyuiu.ArapovTY.Sprint2.Task4.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 15;
            double y = 10;
            double res = ds.Calculate(x, y);
            double wait = 99.867;
            Assert.AreEqual(wait, Math.Round(res, 3));
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = -12;
            double res = ds.Calculate(x, y);
            double wait = 200;
            Assert.AreEqual(wait, Math.Round(res, 3));
        }
    }
}