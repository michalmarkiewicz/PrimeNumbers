using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace PrimeNumbers.Core
{
    public class GridMultiplicator
    {
        public int[,] Calculate(List<int> values)
        {
            if (values == null || values.Count < 1)
                return new int[0, 0];

            var rowSize = values.Count + 1;
            var grid = new int[rowSize, rowSize];

            for (int i = 0; i < rowSize; i++)
            {
                for (int j = 0; j < rowSize; j++)
                {
                    if (i == 0)
                    {
                        if (j == 0)
                        {
                            grid[i, j] = -1;
                            continue;
                        }

                        grid[i, j] = values[j - 1];
                    }
                    else
                    {
                        if (j == 0)
                        {
                            grid[i, j] = values[i - 1];
                            continue;
                        }

                        grid[i, j] = values[i - 1] * values[j - 1];
                    }
                }
            }

            return grid;
        }
    }
}