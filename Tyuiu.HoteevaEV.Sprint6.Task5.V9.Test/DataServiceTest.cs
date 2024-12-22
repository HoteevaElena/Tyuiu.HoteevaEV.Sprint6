using Tyuiu.HoteevaEV.Sprint6.Task5.V9.Lib;
using System.IO;
namespace Tyuiu.HoteevaEV.Sprint6.Task5.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string path = @"C:\DataSprint6\InPutDataFileTask5V9.txt";
            DataService ds = new DataService();
            double[] wait = { 0, 0 };
            double[] res = ds.LoadFromDataFile(path);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}