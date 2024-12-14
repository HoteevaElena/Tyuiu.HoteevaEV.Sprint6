using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.HoteevaEV.Sprint6.Task3.V10.Lib
{
    public class DataService : ISprint6Task3V10
    {
        public int[,] Calculate(int[,] matrix)
        {
            int i = 4;
            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] % 2 == 0)
                {
                    matrix[i, j] = 0;
                }
            }
            return matrix;
        }
    }
}
