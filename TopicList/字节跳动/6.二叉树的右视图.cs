using WF.LetCode.Common;
using WF.LetCode.Common.Model;

namespace WenFanLeetCode.TopicList
{

    /// <summary>
    /// 199. 二叉树的右视图
    ///思路：层序遍历
    /// </summary>
    public class 二叉树的右视图
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<int> RightSideView(TreeNode root)
        {
            var result = new List<int>();
            if (root == null)
            {
                return result;
            }

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Any())
            {
                var queueCount = queue.Count;
                for (int i = queueCount; i > 0; i--)
                {
                    var curNode = queue.Dequeue();
                    if (i == 1)
                    {
                        result.Add(curNode.val);
                    }
                    if (curNode.left != null)
                    {
                        queue.Enqueue(curNode.left);
                    }
                    if (curNode.right != null)
                    {
                        queue.Enqueue(curNode.right);
                    }

                }
            }

            return result;
        }
    }
}