using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.TsvetkovRA.Sprint2.Task7.V1.Lib
{
    public class DataService : ISprint2Task7V1
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            if (x * x + y * y <= 1.0 && y >= 0 && Math.Abs(x) <= y)
                return true;
            else
                return false;

        }
    }
}
