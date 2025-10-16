using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TsvetkovRA.Sprint2.Task3.V21.Lib
{
    public class DataService : ISprint2Task3V21
    {
        public double Calculate(double x)
        { 
            double res = new double();

            if (x > 1)
            {
                res = x * Math.Pow(((x + 9) / (x - 1)), x);
            }
            else if (x == 0)
            {
                res = (Math.Pow(x, 2) + 10) / (Math.Pow(x, 2) - Math.Pow(Math.Sin(x), 2) + 12);
            }
            else if (-25 < x && x < 2)
            {
                res = Math.Pow(1 + (1 / Math.Pow(x, 2)), x);
            }
            else if (x < -25)
            {
                res = x + 10 * x - (1 / x);

            }
            return Math.Round(res, 3);
        }
    }
}
