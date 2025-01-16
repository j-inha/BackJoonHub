using System;

public class Solution {
    public int solution(int a, int b) {
        int answer = 0;
        string ra = a.ToString() + b.ToString();
        string rb = b.ToString() + a.ToString();
        if(int.Parse(ra) >= int.Parse(rb)) {
            answer = int.Parse(ra);
        }
        else {answer = int.Parse(rb);}
        return answer;
    }
}