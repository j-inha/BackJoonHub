using System;

public class Solution {
    public int solution(int[] num_list) {
        string a = "", b ="";
        for(int i = 0; i < num_list.Length; i++){
            if(num_list[i] %2 != 0){
                a += num_list[i].ToString();
            }
            else b += num_list[i].ToString();
        }
        int sum = int.Parse(a) + int.Parse(b);
        Console.WriteLine($"홀수만 이어 붙인 수는 {a}이고 짝수만 이어 붙인 수는 {b}입니다. 두 수의 합은 {sum}입니다.");
        return sum;
    }
}