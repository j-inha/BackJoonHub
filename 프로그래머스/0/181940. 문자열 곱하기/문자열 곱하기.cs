using System;

public class Solution {
    public string solution(string my_string, int k) {
        string answer = "";
        while(k-->0){
            answer += my_string;
        }
        return answer;
    }
}