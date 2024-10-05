using Tyuiu.ArapovTY.Sprint2.Task3.V24.Lib;
namespace Tyuiu.ArapovTY.Sprint2.Task3.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 3;
            double res = ds.Calculate(x);
            double wait = 144.261;
            Assert.AreEqual(wait, Math.Round(res, 3));
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = 1;
            Assert.AreEqual(wait, Math.Round(res, 3));
        }
        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double x = -2;
            double res = ds.Calculate(x);
            double wait = 0.64;
            Assert.AreEqual(wait, Math.Round(res, 3));
        }
        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            double x = -30;
            double res = ds.Calculate(x);
            double wait = 600.033;
            Assert.AreEqual(wait, Math.Round(res, 3));
        }
    }
}