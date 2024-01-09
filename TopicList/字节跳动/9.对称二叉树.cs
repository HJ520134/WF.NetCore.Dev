using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WF.LetCode.Common;
using WF.LetCode.Common.Model;

namespace WenFanLeetCode.TopicList
{
    /// <summary>
    /// 照镜子
    /// </summary>
    public class 对称二叉树
    {
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null)
            {
                return false;
            }

            return Compare(root.left, root.right);
        }

        public bool Compare(TreeNode left, TreeNode right)
        {
            if (left == null && right != null)
            {
                return false;
            }

            if (right == null && left != null)
            {
                return false;
            }

            if (left == null && right == null)
            {
                return true;
            }

            if (left.val != right.val)
            {
                return false;
            }
            else
            {
                //照镜子
                return Compare(left.left, right.right) && Compare(left.right, right.left);
            }
        }
    }
}