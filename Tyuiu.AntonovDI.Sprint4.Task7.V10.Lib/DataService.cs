using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.AntonovDI.Sprint4.Task7.V10.Lib
{
    public class DataService : ISprint4Task7V10
    {
        public int Calculate(int n, int m, string value)
        {
            
            int ind = 0;int count = 0;
            int[,] mas = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mas[i, j] = int.Parse(value.Substring(ind, 1));
                    ind++;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (mas[i, j] % 2 != 0)
                    {
                        count += mas[i, j];
                    }
                }
            }
            return count;
        }
    }
}
