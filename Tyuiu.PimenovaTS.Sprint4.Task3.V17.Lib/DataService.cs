using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.PimenovaTS.Sprint4.Task3.V17.Lib
{
    public class DataService : ISprint4Task3V17
    {
        public int Calculate(int[,] array)
        {
            int kols = array.GetUpperBound(0) + 1;
            int kolst = array.Length / kols;
            int job = 0;

            for (int i = 0; i < kols; i++)
            {
                for (int j = 0; j < kolst; j++)
                {
                    if (j == 3)
                    {
                        job += array[i, j];
                    }
                }
            }
            return job;
        }
    }
}
