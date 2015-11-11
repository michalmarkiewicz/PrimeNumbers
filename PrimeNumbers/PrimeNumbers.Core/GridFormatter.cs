using System.Text;

namespace PrimeNumbers.Core
{
    public class GridFormatter
    {
        public string Formatt(int[,] grid)
        {
            if (grid == null)
                return string.Empty;

            var sb = new StringBuilder();

            var rows = grid.GetLength(0);
            for (int i = 0; i < rows; i++)
            {
                var columns = grid.GetLength(1);
                for (int j = 0; j < columns; j++)
                {
                    if (i == 0 && j == 0)
                        sb.Append(" \t");
                    else if (i != rows - 1 && j == columns - 1)
                        sb.AppendLine(grid[i, j].ToString());
                    else if (i == rows - 1 && j == columns - 1)
                        sb.Append(grid[i, j]);
                    else
                        sb.Append(grid[i, j] + "\t");
                }
            }

            return sb.ToString();
        }
    }
}