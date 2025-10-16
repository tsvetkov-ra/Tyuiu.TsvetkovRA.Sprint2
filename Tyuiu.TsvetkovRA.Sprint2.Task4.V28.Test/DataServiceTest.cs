using Tyuiu.TsvetkovRA.Sprint2.Task4.V28.Lib;
namespace Tyuiu.TsvetkovRA.Sprint2.Task4.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 6.0;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(9.0, res);
        }
        [TestMethod]
        public void ValidCalculate2()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 1.0;
            double res = ds.Calculate(x, y);    
            Assert.AreEqual(1.475, res);    
        }
    }
}
