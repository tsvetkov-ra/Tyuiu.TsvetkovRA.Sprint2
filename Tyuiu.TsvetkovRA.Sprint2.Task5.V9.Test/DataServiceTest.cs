using Tyuiu.TsvetkovRA.Sprint2.Task5.V9.Lib;
namespace Tyuiu.TsvetkovRA.Sprint2.Task5.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfNextDay()
        {
            DataService ds = new DataService();
            int m = 1;
            int n = 13;
            int res = new int();
            res = n + 1;
            Assert.AreEqual(ds.FindDateOfNextDay(m, res), "14.1");
        }
    }
}
