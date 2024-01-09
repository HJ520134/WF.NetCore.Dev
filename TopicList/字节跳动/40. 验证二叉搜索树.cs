using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WF.LetCode.Common;
using WF.LetCode.Common.Model;

namespace WenFanLeetCode.TopicList
{
    public class 验证二叉搜索树
    {
        long cur = long.MinValue;
        public bool IsValidBST(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            //左子树
            if (!IsValidBST(root.left))
            {
                return false;
            }

            if (root.val <= cur)
            {
                return false;
            }
            cur = root.val;

            //右子树
            if (!IsValidBST(root.right))
            {
                return false;
            }

            return true;
        }
    }
}