namespace LeetCode_ProductofArrayExceptSelf
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Hello world !");
        }

        public static int[] ProductExceptSelf(int[] nums)
        {
            int n = nums.Length;
            var production = new int[n];

            for (int i = 0; i < n; i++)
            {
                production[i] = 1;
            }

            int temp = 1;
            for (int i = 0; i < n; i++)
            {
                production[i] *= temp;
                temp *= nums[i];
            }

            temp = 1;
            for (int i = n - 1; i  >= 0; i--)
            {
                production[i] *= temp;
                temp *= nums[i];
            }
            

            return production;
        }
    }
}


