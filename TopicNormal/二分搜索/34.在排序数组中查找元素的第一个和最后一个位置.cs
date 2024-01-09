namespace WF.LeetCode.Category.二分搜索
{
    public class _34
    {
        public int[] SearchRange1(int[] nums, int target)
        {
            var leftValue = -1;
            var rightValue = -1;
            //寻找左边界
            var left = 0; var right = nums.Length - 1;
            while (left <= right)
            {
                var mid = left + (right - left) / 2;
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
                    right = mid - 1;
                }
            }

            if (left < 0 || left >= nums.Length)
            {
                leftValue = -1;
            }
            else
            {
                leftValue = nums[left] == target ? left : -1;
            }

            //寻找右边界
            left = 0; right = nums.Length - 1;
            while (left <= right)
            {
                var mid = left + (right - left) / 2;
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
                    left = mid + 1;
                }
            }

            if (right < 0 || right >= nums.Length)
            {
                rightValue = -1;
            }
            else
            {
                rightValue = nums[right] == target ? right : -1;
            }

            return new int[] { leftValue, rightValue };
        }

        public int[] SearchRange(int[] nums, int target)
        {
            var leftIndex = left_bound(nums, target);
            var rightIndex = right_bound(nums, target);
            return new int[] { leftIndex, rightIndex };
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
