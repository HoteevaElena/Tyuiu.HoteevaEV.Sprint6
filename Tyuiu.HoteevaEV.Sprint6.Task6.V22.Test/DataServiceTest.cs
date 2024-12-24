using System.IO;
using Tyuiu.HoteevaEV.Sprint6.Task6.V22.Lib;
namespace Tyuiu.HoteevaEV.Sprint6.Task6.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint6\InPutDataFileTask6V22.txt";

            string wait = "MLgyapdkEPQzlIOuDWllTMRyztkPxzEVkcarVMlQunwTmf";
            string res = ds.CollectTextFromFile("", path);

            Assert.AreEqual(wait, res);
        }
    }
}