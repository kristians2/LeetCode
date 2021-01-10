using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Islands
    {
        public int NumIslands(char[][] grid)
        {
            int islands = 0;

            HashSet<(int, int)> visited = new HashSet<(int, int)>();

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    (int, int) loc = (i, j);

                    if (!visited.Contains(loc) && grid[i][j] != '0')
                    {
                        islands++;
                        Bfs(visited, grid, loc);
                    }
                }
            }

            return islands;
        }

        private void Bfs(HashSet<(int, int)> visited, char[][] grid, (int, int) loc)
        {
            Queue<(int, int)> q = new Queue<(int, int)>();
            q.Enqueue(loc);

            int h = grid.Length;
            int w = grid[0].Length;

            while(q.Count > 0)
            {
                (int, int) current = q.Dequeue();
                
                int row = current.Item1;
                int col = current.Item2;

                if (row < 0 ||
                    row >= h ||
                    col < 0 ||
                    col >= w ||
                    grid[row][col] == '0' ||
                    visited.Contains(current))
                {
                    continue;
                }

                visited.Add(current);

                q.Enqueue((row - 1, col));
                q.Enqueue((row + 1, col));
                q.Enqueue((row, col - 1));
                q.Enqueue((row, col + 1));
            }
        }
    }
}
