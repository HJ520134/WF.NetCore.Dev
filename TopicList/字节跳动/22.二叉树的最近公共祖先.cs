using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WenFanLeetCode.Mode;

namespace WenFanLeetCode.TopicList
{
    public class 二叉树的最近公共祖先
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            return find(root, p.val, q.val);
        }

        public TreeNode find(TreeNode root, int val1, int val2)
        {
            if (root == null)
            {
                return null;
            }

            if (root.val == val1 || root.val == val2)
            {
                return root;
            }

            var left = find(root.left, val1, val2);
            var right = find(root.right, val1, val2);
            //左右子节点都不为空 找到了
            if (left != null && right != null)
            {
                return root;
            }

            // root 不是目标节点，再去看看哪边的子树找到了
            return left != null ? left : right;
        }
    }
}