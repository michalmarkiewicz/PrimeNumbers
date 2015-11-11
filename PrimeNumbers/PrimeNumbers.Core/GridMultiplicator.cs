using System.Collections.Generic;
using PrimeNumbers.Contracts;

namespace PrimeNumbers.Core
{
    public class GridMultiplicator : IGridMultiplicator
    {
        public int[,] Calculate(List<int> numbers)
        {
            if (numbers == null || numbers.Count < 1)
                return new int[0, 0];
            
            var grid = Grid(numbers);

            return grid;
        }

        private int[,] Grid(List<int> numbers)
        {
            var rowSize = numbers.Count + 1; ;
            var grid = new int[rowSize, rowSize];

            for (int rows = 0; rows < rowSize; rows++)
            {
                for (int columns = 0; columns < rowSize; columns++)
                {
                    if (rows == 0)
                    {
                        if (columns == 0)
                        {
                            grid[rows, columns] = -1;
                            continue;
                        }

                        grid[rows, columns] = numbers[columns - 1];
                    }
                    else
                    {
                        if (columns == 0)
                        {
                            grid[rows, columns] = numbers[rows - 1];
                            continue;
                        }

                        grid[rows, columns] = numbers[rows - 1] * numbers[columns - 1];
                    }
                }
            }

            return grid;
        }
    }
}