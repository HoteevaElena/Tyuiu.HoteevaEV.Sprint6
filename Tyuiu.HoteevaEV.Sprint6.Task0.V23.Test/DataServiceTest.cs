using Tyuiu.HoteevaEV.Sprint6.Task0.V23.Lib;
namespace Tyuiu.HoteevaEV.Sprint6.Task0.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int x = 3;
            var res = ds.Calculate(x);
            double wait = -0.223;

            Assert.AreEqual(wait, res);
        }
    }
}