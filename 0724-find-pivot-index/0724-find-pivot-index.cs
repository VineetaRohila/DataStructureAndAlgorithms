public class Solution {

    //TC : o(N) SC : O(N)
  /*  public int PivotIndex(int[] nums) {
        int n = nums.Length;
        int[] prefSum = GetPefixSumArray(nums, n);

        int sumL, sumR;
        for (int i = 0; i < n; i++)
        {
            if (i == 0)
            {
                sumL = 0;
                sumR = prefSum[n-1] - prefSum[i];

            }

            else if (i == n-1)
            {
                sumR = 0;
                sumL = prefSum[i-1];

            }

            else
            {
                sumL = prefSum[i-1];
                sumR = prefSum[n-1] - prefSum[i];
            }

            if (sumL == sumR)
            return i;
        }

        return -1;
        
    }

    private int[] GetPefixSumArray(int[] nums, int n)
    {
        int[] pSum = new int[n];

        for (int i = 0; i < n; i++)
        {
            pSum[i] = i == 0 ? nums[i] : pSum[i-1] + nums[i];
        }

        return pSum;
    } */

    public int PivotIndex(int[] nums) {

        int totalSum = nums.Sum();
        int leftSum = 0;
        int rtSum;

        for (int i = 0; i < nums.Length; i++)
        {
            leftSum = i == 0 ? 0 : leftSum + nums[i-1];
            rtSum = totalSum - leftSum - nums[i];
            
            if (leftSum == rtSum)
            return i;
        }

        return -1;
    }
}