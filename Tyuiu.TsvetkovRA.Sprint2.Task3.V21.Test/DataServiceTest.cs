using Tyuiu.TsvetkovRA.Sprint2.Task3.V21.Lib;
namespace Tyuiu.TsvetkovRA.Sprint2.Task3.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = 0.833;
            Assert.AreEqual(ds.Calculate(x), res);


        }
    }
}
