
namespace Algorithms
{
    public static class TwoPointerSolver
    {
        public static int[] Findbytwosumtp(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left < right)
            {
                int total = nums[left] + nums[right];
                if (total == target)
                {
                    return new int[] { left, right };
                }
                else if (total < target)
                {
                    left += 1;
                }
                else
                {
                    right -= 1;
                }

            }
            return new int[0];

        }
    }
}
