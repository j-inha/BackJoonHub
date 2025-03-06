using System;

public class Solution {
    public int[,] solution(int n)
    {
        int[,] answer = new int[n,n];
        for(int x =0 ; x < answer.GetLength(0);x++)
        {
            for(int y = 0; y < answer.GetLength(1);y++)
            {
                if(x ==y)
                {
                    answer[x,y] =1;
                }
                else answer[x,y] = 0;
            }
        }
            return answer;
    }
}