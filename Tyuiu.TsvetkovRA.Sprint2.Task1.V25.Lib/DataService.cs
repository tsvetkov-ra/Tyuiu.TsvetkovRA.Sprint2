using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.TsvetkovRA.Sprint2.Task1.V25.Lib
{
    public class DataService : ISprint2Task1V25
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (a == b) || (c != d);
            res[1] = a + 18 == d;
            res[2] = (a != b) && (a !=c);
            res[3] = a == 5125 - 13;
            res[4] = a == a + b - 155;
            res[5] = (a + d == 2000) || (d != b + 702);
            return res;

        }
    }
}
