using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.HoteevaEV.Sprint6.Task4.V22.Lib
{
    public class DataService : ISprint6Task4V22
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] m = new double[len];
            int count = 0;
            for(int x = startValue; x <= stopValue; x++)
            {
                m[count] = Math.Round((Math.Sin(x) + ((Math.Cos(2 * x)) / 2) - 1.5 * x), 2);
                count++;
            }
            return m;
            
        }
    }
}
