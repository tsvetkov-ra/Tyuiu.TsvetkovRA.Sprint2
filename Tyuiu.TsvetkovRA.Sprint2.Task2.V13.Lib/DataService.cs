using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.TsvetkovRA.Sprint2.Task2.V13.Lib
{
    public class DataService : ISprint2Task2V13
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            if (x == 6 && y == 3 || x == 11 && y == 3 || y == 4 && 2 <= x && x <= 8 || y == 4 && x == 11 || x == 6 && y == 5 || x == 11 && y == 5 || x == 6 && y == 6 || x == 10 && y == 6 || x == 11 && y == 6 || x == 6 && y == 7 || x >= 10 && x <= 12 && y == 7 || x >= 5 && x <= 12 && y == 8 || x >= 3 && x <= 12 && y == 9 || x >= 3 && x <= 10 && y == 10 || x >= 3 && x <= 10 && y == 11 || x >= 3 && x <= 10 && y == 12 || x >= 6 && x <= 9 && y == 13)
            {
                res = true;
            }

            else
            {
                res = false;
            }
            return res;
        }

    }
}
