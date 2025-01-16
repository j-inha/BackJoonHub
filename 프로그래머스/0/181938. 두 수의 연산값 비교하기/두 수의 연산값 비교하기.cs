using System;

public class Solution {
    public int solution(int a, int b) {
        int answer = 0;
        string ra = a.ToString() + b.ToString();
        int rb = 2 * a * b;
        if(int.Parse(ra) >= rb){
            answer = int.Parse(ra);
        }
        else {answer = rb;}
        return answer;
    }
}