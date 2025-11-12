using System.Timers;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.AntonovDI.Sprint4.Task6.V4.Lib
{
    public class DataService : ISprint4Task6V4
    {
        public string[] Calculate(string[] array)
        {
            string[] mas = Array.FindAll(array, x => x.Length < 7);
            return mas;
        }
    }
}
