using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WenFanLeetCode.Mode;

namespace WenFanLeetCode.TopicList
{
    public class 二叉树展开为链表
    {
        public void Flatten(TreeNode root)
        {
            var nodeList = new List<TreeNode>();
            preorderTraversal(root, nodeList);
            for (int i = 1; i < nodeList.Count; i++)
            {
                var preNode = nodeList[i - 1];
                var curNode = nodeList[i];
                preNode.left = null;
                preNode.right = curNode;
            }
        }

        public void preorderTraversal(TreeNode root, List<TreeNode> List)
        {
            if (root == null)
            {
                return;
            }
            List.Add(root);
            preorderTraversal(root.left, List);
            preorderTraversal(root.right, List);
        }


    }
}