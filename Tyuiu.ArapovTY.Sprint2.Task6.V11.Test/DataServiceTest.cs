using Tyuiu.ArapovTY.Sprint2.Task6.V11.Lib;
namespace Tyuiu.ArapovTY.Sprint2.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void ValidFindDateOfNextDay()
        {
            int g;
            Assert.AreEqual("25 �������", ds.FindDateOfNextDay(g, 26, 2));
            Assert.AreEqual("17 ���", ds.FindDateOfNextDay(g, 18, 5));
            Assert.AreEqual("1 ����", ds.FindDateOfNextDay(g, 2, 7));
        }
    }
}