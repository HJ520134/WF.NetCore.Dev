using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WenFanLeetCode.TopicList
{
    public class 岛屿数量
    {
        public int NumIslands(char[][] grid)
        {
            var m = grid.Length; //列
            var n = grid[0].Length; //行
            var res = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        res++;
                        dfs(grid, i, j);
                    }
                }
            }
            return res;
        }

        public void dfs(char[][] grid, int i, int j)
        {
            var m = grid.Length; //列
            var n = grid[0].Length; //行
            if (i < 0 || j < 0 || i >= m || j >= n)
            {
                return;
            }
            //遇到海水直接返回
            if (grid[i][j] == '0')
            {
                return;
            }
            //走过的岛屿转成海水 避免重复遍历
            grid[i][j] = '0';
            //上下左右的淹没岛屿
            dfs(grid, i + 1, j);
            dfs(grid, i - 1, j);
            dfs(grid, i, j - 1);
            dfs(grid, i, j + 1);
        }
    }
}