using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.PimenovaTS.Sprint4.Task4.V11.Lib
{
    public class DataService : ISprint4Task4V11
    {
        public int Calculate(int[,] matrix)
        {
            int kols = matrix.GetUpperBound(0) + 1;
            int kolst = matrix.Length / kols;
            int job = 0;

            for (int i = 0; i < kols; i++)
            {
                for (int j = 0; j < kolst; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        job += matrix[i, j];
                    }
                }
            }
            return job;
        }
    }
}
