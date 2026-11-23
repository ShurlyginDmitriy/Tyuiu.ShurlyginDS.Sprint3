using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ShurlyginDS.Sprint3.Task2.V6.Lib
{
    public class DataService : ISprint3Task2V6
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double p = 1.0;
            int k = startValue;

            do
            {
                p *= (Math.Pow(value, k) + 1) * Math.Cos(4);
                k++;
            } while (k <= stopValue);

            return Math.Round(p, 3);
        }
    }
}
