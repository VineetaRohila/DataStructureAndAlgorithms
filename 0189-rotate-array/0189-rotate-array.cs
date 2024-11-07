public class Solution {

    //TC : O(N) SC O(1)
    public void Rotate(int[] nums, int k) {

        int n = nums.Length;
        k = k % n;

        //reverse entire array
        Reverse(nums, 0, n-1);
        Reverse(nums, 0, k-1);
        Reverse(nums, k, n-1);
        
    }

    private static void Reverse(int[] arr, int l, int r)
    {
        while(l < r)
        {
            int temp = arr[l];
            arr[l] = arr[r];
            arr[r] = temp;
            l++;
            r--;
        }
    }

    // TC = O(N^2)
   /* public void Rotate(int[] nums, int k) {

        int n = nums.Length;
        k = k % n;

        for (int i = 0; i < k; i++)
        {
            BringLastElmntToFront(nums);
        }
        
    }

    private static void BringLastElmntToFront(int[] nums)
    {
        int n = nums.Length;
        int temp = nums[n-1];

        for (int j = n-1; j >= 1; j--)
        {
            nums[j] = nums[j-1];
        }

        nums[0] = temp;
    } */
}