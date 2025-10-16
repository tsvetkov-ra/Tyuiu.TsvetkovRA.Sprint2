using Tyuiu.TsvetkovRA.Sprint2.Task6.V14.Lib;
namespace Tyuiu.TsvetkovRA.Sprint2.Task6.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDayName()
        {
            DataService ds = new DataService();
            int k = 288;
            int d = 5;
            Assert.AreEqual(ds.FindDayName(k, d), "Пятница");
        }
    }
}
