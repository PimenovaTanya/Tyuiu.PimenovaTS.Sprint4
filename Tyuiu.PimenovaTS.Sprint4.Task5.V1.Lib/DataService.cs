using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.PimenovaTS.Sprint4.Task5.V1.Lib
{
    public class DataService : ISprint4Task5V1
    {
        public int[,] Calculate(int[,] matrix)
        {
            int kols = matrix.GetUpperBound(0) + 1;
            int kolst = matrix.Length / kols;

            for (int i = 0; i < kols; i++)
            {
                for (int j = 0; j < kolst; j++)
                {
                    if (matrix[i, j] >= 0)
                    {
                        matrix[i, j] = 1;
                    }
                }
            }
            return matrix;
        }
    }
}
