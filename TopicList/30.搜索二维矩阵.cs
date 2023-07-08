using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WenFanLeetCode.TopicList
{
    public class 搜索二维矩阵
    {
        /// <summary>
        /// 矩阵二分搜索
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public bool SearchMatrix(int[][] matrix, int target)
        {
            if (matrix.Length == 0)
            {
                return false;
            }
            //行数
            var row = matrix.Length;
            //列数
            var col = matrix[0].Length;
            var left = 0;
            var right = row * col - 1;
            while (left <= right)
            {
                var mid = left + (right - left) / 2;
                var rowNum = mid / col;
                var colNum = mid % col;
                if (matrix[rowNum][colNum] == target)
                {
                    return true;
                }
                else if (target > matrix[rowNum][colNum])
                {
                    left = mid + 1;
                }
                else if (target < matrix[rowNum][colNum])
                {
                    right = mid - 1;
                }
            }

            return false;
        }
    }
}