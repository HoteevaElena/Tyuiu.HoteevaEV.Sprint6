using Tyuiu.HoteevaEV.Sprint6.Task4.V22.Lib;
namespace Tyuiu.HoteevaEV.Sprint6.Task4.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            double[] mass = new double[11];
            mass[0] = 8.04;
            mass[1] = 6.68;
            mass[2] = 4.84;
            mass[3] = 1.76;
            mass[4] = 0.45;
            mass[5] = 0.5;
            mass[6] = -0.87;
            mass[7] = -2.42;
            mass[8] = -3.88;
            mass[9] = -6.83;
            mass[10] = -8.88;
            double[] res = ds.GetMassFunction(-5, 5);
            CollectionAssert.AreEqual(mass, res);
        }
    }
}