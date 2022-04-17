namespace LeetCode_ContainsDuplicate
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine(ContainsDuplicate(new int[] { 1, 2, 3, 1 }));
        }

        public static bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> hash = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (hash.Contains(nums[i]))
                {
                    return true;
                }
                else
                {
                    hash.Add(nums[i]);
                }
            }

            return false;
        }
    }
}