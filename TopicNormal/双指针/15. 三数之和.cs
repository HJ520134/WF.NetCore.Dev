namespace TopicNormal.双指针
{
    public class SolutionThreeSum
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums);
            var n = nums.Length;
            IList<IList<int>> result = new List<IList<int>>();
            for (int i = 0; i < n; i++)
            {
                var tempRes = TwoSum(nums, 0 - nums[i]);
                foreach (var item in tempRes)
                {
                    item.Add(nums[i]);
                    result.Add((List<int>)item);
                }

                while (i < n - 1 && nums[i] == nums[i + 1])
                {
                    i++;
                }
            }
            return result;
        }

        public IList<IList<int>> TwoSum(int[] nums, int target)
        {
            IList<IList<int>> result = new List<IList<int>>();
            var lo = 0; var hi = nums.Length - 1;
            while (lo < hi)
            {
                var sum = nums[lo] + nums[hi];
                var left = nums[lo]; var right = nums[hi];
                if (sum > target)
                {
                    while (lo < hi && nums[hi] == right) { hi--; }
                }
                else if (sum < target)
                {
                    while (lo < hi && left == nums[lo]) { lo++; }
                }
                else
                {
                    var temp = new List<int> { nums[lo], nums[hi] };
                    result.Add(temp);
                    while (lo < hi && left == nums[lo]) { lo++; }
                    while (lo < hi && nums[hi] == right) { hi--; }
                }
            }

            return result;
        }
    }

}
