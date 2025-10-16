using Tyuiu.TsvetkovRA.Sprint2.Task2.V13.Lib;
namespace Tyuiu.TsvetkovRA.Sprint2.Task2.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 2;
            int y = 4;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(res, wait);
            
        }
    }
}
