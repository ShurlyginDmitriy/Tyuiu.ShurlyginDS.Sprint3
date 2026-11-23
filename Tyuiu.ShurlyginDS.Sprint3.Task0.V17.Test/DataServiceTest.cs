using Tyuiu.ShurlyginDS.Sprint3.Task0.V17.Lib;

namespace Tyuiu.ShurlyginDS.Sprint3.Task0.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            int startvalue = 1;
            int stopvalue = 10;

            double res = ds.GetSumSeries(startvalue, stopvalue);

            double wait = -0.709;

            Assert.AreEqual(wait, res);
        }
    }
}
