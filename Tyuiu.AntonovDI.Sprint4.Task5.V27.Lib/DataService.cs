using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.AntonovDI.Sprint4.Task5.V27.Lib
{
    public class DataService : ISprint4Task4V27
    {
        public int Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            int count = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        count += 1;
                    }
                }
            }
            return count;
        }
    }
}
