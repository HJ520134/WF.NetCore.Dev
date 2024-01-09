using WenFanLeetCode.Mode;

namespace TopicNormal.动态规划.打家劫舍;
public class Solution
{
    Dictionary<TreeNode, int> memo = new Dictionary<TreeNode, int>();
    public int Rob(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }
        if (memo.ContainsKey(root))
        {
            return memo[root];
        }

        //抢当前+下一层
        int rotIt = root.val +
        (root.left == null ? 0 : Rob(root.left.left) + Rob(root.left.right)) +
        (root.right == null ? 0 : Rob(root.right.left) + Rob(root.right.right));
        //直接抢下一层
        int rotNot = Rob(root.left) + Rob(root.right);
        var res = Math.Max(rotIt, rotNot);
        memo[root] = res;
        return res;
    }
}