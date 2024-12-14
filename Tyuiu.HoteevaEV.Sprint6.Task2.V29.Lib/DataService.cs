using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.HoteevaEV.Sprint6.Task2.V29.Lib
{
    public class DataService : ISprint6Task2V29
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int i = 0;
            int len = stopValue - startValue + 1;
            double[] vals = new double[len];
            for (int d = startValue; d <= stopValue; d++)
            {
                if (2 * d - 1 == 0)
                {
                    vals[i] = 0; 
                    i++;
                }
                else
                {
                    vals[i] = Math.Round((((2 * Math.Cos(d) + 2) / (2 * d - 1)) + Math.Cos(d) - 5 * d + 3), 2);
                    i++;
                }

            }
            return vals;
        }
    }
}
