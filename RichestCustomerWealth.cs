public class Solution {
    public int MaximumWealth(int[][] accounts) {
        int richest = 0;
        int current = 0;
        
        for(int i = 0; i < accounts.Length;i++)
        {
            for(int j = 0; j < accounts[i].Length;j++)
            {
                current = current + accounts[i][j];
            }
            if(current > richest)
            {
                richest = current;
                current = 0;
            }
            current = 0;
        }
        
        return richest;
    }
}