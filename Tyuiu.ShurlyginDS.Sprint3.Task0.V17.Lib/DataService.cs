using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ShurlyginDS.Sprint3.Task0.V17.Lib
{
    public class DataService : ISprint3Task0V17
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double sumSeries = 0;
            int i;

            for (i = startValue; i <= stopValue; i++)
            {
                sumSeries = sumSeries + (Math.Cos(i) * (1.0 / 2.0));
            }

            return Math.Round(sumSeries, 3);
        }
    }
}
