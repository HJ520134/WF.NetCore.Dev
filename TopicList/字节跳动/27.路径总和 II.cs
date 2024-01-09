using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WF.LetCode.Common;
using WF.LetCode.Common.Model;

namespace WenFanLeetCode.TopicList
{
    /// <summary>
    /// 递归+回溯
    /// </summary>
    public class 路径总和II
    {
        public IList<IList<int>> PathSum(TreeNode root, int targetSum)
        {
            var result = new List<List<int>>();
            dfs_LookBack(root, targetSum, new List<int>(), result);
            return result.ToArray();
        }

        public void dfs(TreeNode root, int sum, List<int> list, List<List<int>> result)
        {
            //如果节点为空直接返回
            if (root == null)
            {
                return;
            }
            //当前节点添加到节点中
            var subList = new List<int>(list);
            subList.Add(root.val);
            //如果到达叶子节点 直接返回
            if (root.left == null && root.right == null)
            {
                if (root.val == sum)
                {
                    result.Add(subList);
                }
                //不会再走最后一行的remove了，所以这里在rerurn之前提前把最后
                return;
            }

            //如果没到达叶子节点，就继续从他的左右两个子节点往下找，注意到
            //下一步的时候，sum值要减去当前节点的值
            dfs(root.left, sum - root.val, subList, result);
            dfs(root.right, sum - root.val, subList, result);
            //我们要理解递归的本质，当递归往下传递的时候他最后还是会往回走，
            //我们把这个值使用完之后还要把它给移除，这就是回溯
        }


        /// <summary>
        /// 递归+回溯算法
        /// </summary>
        /// <param name="root"></param>
        /// <param name="sum"></param>
        /// <param name="list"></param>
        /// <param name="result"></param>
        public void dfs_LookBack(TreeNode root, int sum, List<int> list, List<List<int>> result)
        {
            if (root == null)
            {
                return;
            }

            list.Add(root.val);
            if (root.left == null && root.right == null)
            {
                if (sum == root.val)
                {
                    result.Add(new List<int>(list));
                }

                list.RemoveAt(list.Count - 1);
                return;
            }

            dfs_LookBack(root.left, sum - root.val, list, result);
            dfs_LookBack(root.right, sum - root.val, list, result);

            list.RemoveAt(list.Count - 1);
        }
    }
}