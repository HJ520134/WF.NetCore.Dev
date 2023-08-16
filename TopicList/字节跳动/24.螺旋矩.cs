using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WenFanLeetCode.TopicList
{
    public class 螺旋矩
    {
        public IList<int> SpiralOrder(int[][] matrix)
        {
            var resList = new List<int>();
            if (matrix == null || matrix.Length == 0)
            {
                return resList;
            }
            //行数
            var row = matrix.Length;
            //列数
            var col = matrix[0].Length;
            var level = (Math.Min(row, col) + 1) / 2;
            for (int i = 0; i < level; i++)
            {
                //从左向右
                for (int j = i; j < col - i; j++)
                {
                    resList.Add(matrix[i][j]);
                }
                //从上到下
                for (int j = i + 1; j < row - i; j++)
                {
                    resList.Add(matrix[j][col - 1 - i]);
                }

                //从右到左 考虑只有一行的情况(从左到右边)已经打印
                for (int j = (col - 1) - (i + 1); j >= i && (row - 1 - i != i); j--)
                {
                    resList.Add(matrix[row - 1 - i][j]);
                }

                //从下到上 考虑从下到上只有一列的时候(从上到下)已经打印...
                for (int j = (row - 1) - (i + 1); j >= i + 1 && (col - 1 - i != i); j--)
                {
                    resList.Add(matrix[j][i]);
                }
            }

            return resList;
        }
    }
}