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
    ///
    /// </summary>
    public class 从前序与中序遍历序列构造二叉树
    {
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            if (preorder.Length == 0 || inorder.Length == 0)
            {
                return null;
            }
            //根据前序数组的第一个元素，就可以确定根节点
            TreeNode root = new TreeNode(preorder[0]);
            for (int i = 0; i < preorder.Length; ++i)
            {
                //用preorder[0]去中序数组中查找对应的元素
                if (preorder[0] == inorder[i])
                {
                    //将前序数组分成左右两半，再将中序数组分成左右两半
                    //之后递归的处理前序数组的左边部分和中序数组的左边部分
                    //递归处理前序数组右边部分和中序数组右边部分
                    int[] pre_left = preorder.Skip(1).Take(i).ToArray();
                    int[] pre_right = preorder.Skip(i + 1).ToArray();
                    int[] in_left = inorder.Take(i).ToArray();
                    int[] in_right = inorder.Skip(i + 1).ToArray();
                    root.left = BuildTree(pre_left, in_left);
                    root.right = BuildTree(pre_right, in_right);
                    break;
                }
            }
            return root;
        }
    }
}