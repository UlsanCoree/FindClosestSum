namespace FindClosestSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 5, 11, 7, 15 };
            int target = 10;

            Console.WriteLine(FindClosestSum(nums, target));
        }

        public static int FindClosestSum(int[] nums, int target)
        {
            int closestSum = nums[0] + nums[1];
            int smallDiff = (int)MathF.Abs(target - closestSum);

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    int currSum = nums[i] + nums[j];
                    int currDiff = Math.Abs(target - currSum);

                    if (currDiff < smallDiff)
                    {
                        closestSum = currSum;
                        smallDiff = currDiff;
                    }
                }
            }

            return closestSum;
        }
    }
}
