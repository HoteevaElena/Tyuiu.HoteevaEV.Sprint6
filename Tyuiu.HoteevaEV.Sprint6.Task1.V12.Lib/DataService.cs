using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.HoteevaEV.Sprint6.Task1.V12.Lib
{
    public class DataService : ISprint6Task1V12
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int i = 0;
            int len = stopValue - startValue + 1;
            double[] vals = new double[len];
            for (int d = startValue; d <= stopValue; d++)
            {
                if (2 - d == 0)
                {
                    vals[i] = 0;
                    i++;
                }
                else
                {
                    vals[i] = Math.Round((Math.Sin(d) + ((Math.Cos(d) + 1) / (2 - d) + 2 * d)), 2);
                    i++;
                }

            }
            return vals;
        }
    }
}
