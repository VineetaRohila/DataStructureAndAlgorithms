public class NumArray {

    private readonly int[] PrefixSum;

    public NumArray(int[] nums) 
    {
        int n = nums.Length;

        PrefixSum = new int[n];

    for (int i = 0; i < n; i++)
    {
        PrefixSum[i] = i == 0 ? nums[i] : PrefixSum[i-1] + nums[i];
    }
    
    }
    
    public int SumRange(int left, int right) {
        if (left == 0)
        return PrefixSum[right];
        else
        return (PrefixSum[right] - PrefixSum[left-1]);
        
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */