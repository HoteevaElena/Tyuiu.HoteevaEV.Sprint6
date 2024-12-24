using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;
namespace Tyuiu.HoteevaEV.Sprint6.Task6.V22.Lib
{
    public class DataService : ISprint6Task6V22
    {
        public string CollectTextFromFile(string str, string path)
        {
            string full = "";

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] mass = line.Split(" ").ToArray();
                    full += mass[0];
                }
            }

            return full;
        }
    }
}
