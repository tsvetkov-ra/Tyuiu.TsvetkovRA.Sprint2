using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.TsvetkovRA.Sprint2.Task5.V9.Lib
{
    public class DataService : ISprint2Task5V9
    {
        public string FindDateOfNextDay(int m, int n)
        {
           

         int res = 0;

            switch (m)
            {
                case 1:
                    res = 31;
                    break;
                case 2:
                    res = 28; 
                    break;
                case 3:
                    res = 31;
                    break;
                case 4:
                    res = 30;
                    break;
                case 5:
                    res = 31;
                    break;
                case 6:
                    res = 30;
                    break;
                case 7:
                    res = 31;
                    break;
                case 8:
                    res = 31;
                    break;
                case 9:
                    res = 30;
                    break;
                case 10:
                    res = 31;
                    break;
                case 11:
                    res = 30;
                    break;
                case 12:
                    res = 31;
                    break;
               
            }
            n = n + 1;

            if (n < 1 || n > res)
                throw new ArgumentException("Некорректный день для указанного месяца.");

            else if (n < res)
                
                return ("Следующая дата " + n + "." + m);
            else
                return ("Следующая дата 1." + m);



        }
    }
}
