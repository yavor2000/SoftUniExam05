/* Problem 2. Pairs
 */

using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] str = input.Split(' ');
        int[] nums = new int[str.Length];
        int n = nums.GetLength(0);
        for (int i = 0; i < n; i++) nums[i] = int.Parse(str[i]);
        int diff = int.MinValue;
        int sum0 = int.MinValue;
        int sum1 = int.MinValue;
        bool ravni = true;
        for (int i = 0; i < n / 2; i++)
        {
            if (i == 0) sum0 = nums[i * 2] + nums[i * 2 + 1];
            else
            {
                sum1 = nums[i * 2] + nums[i * 2 + 1];
                if (sum1 != sum0)
                {
                    ravni = false;
                    if (diff < Math.Abs(sum1 - sum0)) diff = Math.Abs(sum1 - sum0);
                }
                sum0 = sum1;
            }
        }
        if (ravni) Console.WriteLine("Yes, value={0}", sum0);
        else Console.WriteLine("No, maxdiff={0}", diff);
    }
}