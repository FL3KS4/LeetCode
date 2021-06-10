public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int result = 0;
        int tmp = 0;
        for(int i = 0; i < nums.Length;i++)
        {
            if(nums[i] == 1)
            {
                result++;
            }
            else if(nums[i] == 0)
            {
                if(tmp < result)
                {
                    tmp = result;
                }                
                result = 0;
            }
        }  
        
        if(tmp > result)
        {
            return tmp;
        }
        else
            return result;
        
    }
}