using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WenFanLeetCode.TopicList
{
    public class 单词搜索
    {
        private int row;
        private int col;
        private int wordlen;
        public bool Exist(char[][] board, string word)
        {
            row = board.Length;
            col = board[0].Length;
            wordlen = word.Length;
            int[,] visited = new int[row, col];
            var wordChar = word.ToCharArray();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (board[i][j] != wordChar[0])
                    {
                        continue;
                    }
                    if (Dfs(board, i, j, wordChar, 0, visited))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public bool Dfs(char[][] board, int m, int n, char[] word, int index, int[,] visited)
        {
            if (index == wordlen - 1)
            {
                return true;
            }

            if (m < 0 || n < 0 || m >= board.Length || n >= board[0].Length || board[m][n] != word[index] || visited[m, n] == 1)
            {
                return false;
            }
            visited[m, n] = 1;
            if (Dfs(board, m - 1, n, word, index + 1, visited)) { return true; }
            if (Dfs(board, m, n + 1, word, index + 1, visited)) { return true; }
            if (Dfs(board, m + 1, n, word, index + 1, visited)) { return true; }
            if (Dfs(board, m, n - 1, word, index + 1, visited)) { return true; }
            visited[m, n] = 0;
            return false;
        }
    }
}