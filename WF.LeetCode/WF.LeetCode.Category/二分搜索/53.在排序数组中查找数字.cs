namespace WF.LeetCode.Category.二分搜索
{
    public class _53
    {
        public int Search(int[] nums, int target)
        {
            var leftIndex = left_bound(nums, target);
            var rightIndex = right_bound(nums, target);
            if (rightIndex == -1 || leftIndex == -1)
            {
                return 0;
            }
            return (rightIndex - leftIndex) + 1;
        }

        public int left_bound(int[] nums, int target)
        {
            int left = 0, right = nums.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] < target)
                {
                    left = mid + 1;
                }
                else if (nums[mid] > target)
                {
                    right = mid - 1;
                }
                else if (nums[mid] == target)
                {
                    // 别返回，锁定左侧边界
                    right = mid - 1;
                }
            }
            // 判断 target 是否存在于 nums 中
            if (left < 0 || left >= nums.Length)
            {
                return -1;
            }
            // 判断一下 nums[left] 是不是 target
            return nums[left] == target ? left : -1;
        }

        public int right_bound(int[] nums, int target)
        {
            int left = 0, right = nums.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] < target)
                {
                    left = mid + 1;
                }
                else if (nums[mid] > target)
                {
                    right = mid - 1;
                }
                else if (nums[mid] == target)
                {
                    // 别返回，锁定右侧边界
                    left = mid + 1;
                }
            }

            if (right < 0 || right >= nums.Length)
            {
                return -1;
            }

            return nums[right] == target ? right : -1;
        }
    }
}
