using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;
using System.Security.Cryptography.X509Certificates;
namespace Tyuiu.HoteevaEV.Sprint6.Task5.V9.Lib
{
    public class DataService : ISprint6Task5V9
    {
        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    len++;
                }
            }
            double[] mass = new double[len];

            int ind = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    mass[ind] = Convert.ToDouble(line);
                    ind++;
                }
            }

            mass = mass.Where(val => val == 0).ToArray();

            return mass;
        }
    }
}
