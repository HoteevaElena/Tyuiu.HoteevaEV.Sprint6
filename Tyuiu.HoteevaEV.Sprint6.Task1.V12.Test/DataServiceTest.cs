using Tyuiu.HoteevaEV.Sprint6.Task1.V12.Lib;
namespace Tyuiu.HoteevaEV.Sprint6.Task1.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunc()
        {
            DataService ds = new DataService();

            int s = -5;
            int e = 5;

            double[] nums = new double[e - s + 1];

            nums[0] = -8.86;
            nums[1] = -7.19;
            nums[2] = -6.14;
            nums[3] = -4.76;
            nums[4] = -2.33;
            nums[5] = 1;
            nums[6] = 4.38;
            nums[7] = 0;
            nums[8] = 6.13;
            nums[9] = 7.07;
            nums[10] = 8.61;

            double[] res = new double[e - s + 1];
            res = ds.GetMassFunction(s, e);

            CollectionAssert.AreEqual(nums, res);

        }
    }
}