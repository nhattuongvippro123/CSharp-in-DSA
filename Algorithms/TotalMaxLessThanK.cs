namespace Algorithms
{
    public static class TotalMaxLessThanK
    {
        public static int[] FindTwoNumHasMaxLessThanK(int[] numsttltk, int k)
        {
            int left = 0;
            int right = numsttltk.Length - 1;
            int max = -1;
            int[] result = new int[2];
            while (left < right)
            {
                int total = numsttltk[left] + numsttltk[right];
                if (total < k)
                {
                    max = Math.Max(max, total);
                    result[0] = left;
                    result[1] = right;
                    left++;
                }
                else
                {
                    right--;
                }
            }
            return result;

        }
    }
}

