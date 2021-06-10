public class Solution {
    int counter = 0;
    
    public int get_int_len (int value)
    {
      int l=1;
      while(value>9){ l++; value/=10; }
      return l;
    }
    
    public int FindNumbers(int[] nums) 
    {
        for(int i = 0; i < nums.Length;i++)
        {
            int a = get_int_len(nums[i]);
            if(a % 2 == 0)
            {
                counter++;
            }
        }
        
        return counter;
    }
}