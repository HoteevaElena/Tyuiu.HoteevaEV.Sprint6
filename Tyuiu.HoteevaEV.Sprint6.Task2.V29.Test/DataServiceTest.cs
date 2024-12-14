using Tyuiu.HoteevaEV.Sprint6.Task2.V29.Lib;
namespace Tyuiu.HoteevaEV.Sprint6.Task2.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int s = -5;
            int e = 5;

            double[] nums = new double[e - s + 1];

            nums[0] = 28.05;
            nums[1] = 22.27;
            nums[2] = 17.01;
            nums[3] = 12.35;
            nums[4] = 7.51;
            nums[5] = 0;
            nums[6] = 1.62;
            nums[7] = -7.03;
            nums[8] = -12.99;
            nums[9] = -17.55;
            nums[10] = -21.43;

            double[] res = new double[e - s + 1];
            res = ds.GetMassFunction(s, e);

            CollectionAssert.AreEqual(nums, res);
        }
    }
}